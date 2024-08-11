using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : DoorGUID, IInteractable
{
    public Animator doorAnimator;
    public AudioSource source;
    public AudioClip openDoor, closeDoor;

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
            DoorInteraction();
            source.clip = _isOpen ? openDoor : closeDoor;
            source.Play();
        }
    }
}
