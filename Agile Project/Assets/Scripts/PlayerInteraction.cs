using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            AttemptInteraction();
        }
    }

    private void AttemptInteraction()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1.5f))
        {
            Debug.Log("Hit");
            
            GameObject hitObj = hit.transform.gameObject;
            if (hitObj.GetComponent<IInteractable>() == null)
                return;

            hitObj.GetComponent<IInteractable>().Interact(gameObject);
        }
    }
}
