using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoor : DoorGUID, IInteractable
{
    [SerializeField] private Collider _inventory;
    [SerializeField] private GameObject _key;
    [SerializeField] private GameObject _needKey;

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
            if (_inventory.bounds.Contains(_key.transform.position))
            {
                DoorInteraction();
                source.clip = _isOpen ? openDoor : closeDoor;
                source.Play();
            }
            else
            {
                _needKey.SetActive(true);
                StartCoroutine(CloseMenu());
            }
        }
    }

    public IEnumerator CloseMenu()
    {
        yield return new WaitForSeconds(2);
        _needKey.SetActive(false);
    }

}
