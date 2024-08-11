using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float _maxInteractDistance;
    [SerializeField] private Transform _weaponHoldPoint;
    [SerializeField] private GameObject _curWeapon;
    [SerializeField] private GameObject _interactButton;

    private GameObject _player;
    public GameObject CurWeapon { get { return _curWeapon; } }

    private void Start()
    {
        _player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit interaction;
        if (Physics.Raycast(transform.position + new Vector3(0, 1.5f, 0), transform.forward, out interaction, _maxInteractDistance))
        {
            GameObject hitObj = interaction.transform.gameObject;

            if (hitObj.GetComponent<IInteractable>() != null && !hitObj.transform.IsChildOf(_player.transform))
            {
                _interactButton.SetActive(true);
            }
            else
            {
                _interactButton.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            AttemptInteraction();
        }
    }

    private void AttemptInteraction()
    {
        RaycastHit playerHit;
        if (Physics.Raycast(transform.position + new Vector3(0, 1.5f, 0), transform.forward, out playerHit, _maxInteractDistance))
        {
            GameObject hitObj = playerHit.transform.gameObject;

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

        _curWeapon = weaponToPickup;

        _curWeapon.transform.parent = _weaponHoldPoint;
        _curWeapon.transform.rotation = _weaponHoldPoint.rotation;
        _curWeapon.transform.localPosition = Vector3.zero;

    }
}
