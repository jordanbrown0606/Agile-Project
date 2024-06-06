using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float _maxInteractDistance;
    [SerializeField] private Transform _weaponHoldPoint;
    [SerializeField] private GameObject _curWeapon;
    public GameObject CurWeapon { get { return _curWeapon; } }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position + new Vector3(0, 1.5f, 0), transform.forward, Color.red);

        if (Input.GetKeyDown(KeyCode.E))
        {
            AttemptInteraction();
        }
    }

    private void AttemptInteraction()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position + new Vector3(0, 1.5f, 0), transform.forward, out hit, _maxInteractDistance))
        {
            GameObject hitObj = hit.transform.gameObject;

            Debug.Log("Hit " + hitObj.name);
            
            if (hitObj.GetComponent<IInteractable>() == null)
            {
                return;
            }

            hitObj.GetComponent<IInteractable>().Interact(this.gameObject);
        }
    }

    /// <summary>
    /// handles weapons position and rotation
    /// </summary>
    public void WeaponPickup(GameObject weaponToPickup)
    {
        if (_curWeapon != null)
        {
            return;
        }

        _curWeapon = weaponToPickup;

        _curWeapon.transform.parent = _weaponHoldPoint;
        _curWeapon.transform.rotation = _weaponHoldPoint.rotation;
        _curWeapon.transform.localPosition = Vector3.zero;

    }
}
