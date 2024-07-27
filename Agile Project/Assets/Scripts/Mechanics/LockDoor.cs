using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoor : MonoBehaviour, IInteractable
{
    [SerializeField] private Collider _inventory;
    [SerializeField] private GameObject _key;

    public Animator doorAnimator;

    private bool _isOpen = false;

    public void DoorInteraction()
    {
        if (!_isOpen)
        {
            doorAnimator.SetTrigger("Open");
            doorAnimator.ResetTrigger("Close");
            _isOpen = true;
        }
        else
        {
            doorAnimator.SetTrigger("Close");
            doorAnimator.ResetTrigger("Open");
            _isOpen = false;
        }
    }

    public void Interact(GameObject objAttemptingInteraction)
    {
        if (objAttemptingInteraction.tag == "Player")
        {
            if (_inventory.bounds.Contains(_key.transform.position))
            {
                DoorInteraction();
            }
        }
    }

}
