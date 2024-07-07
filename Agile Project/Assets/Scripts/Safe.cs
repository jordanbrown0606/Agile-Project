using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Safe : MonoBehaviour, IInteractable
{
    [SerializeField] private Image _keypad;

    public void Interact(GameObject objAttemptingInteraction)
    {
        objAttemptingInteraction.GetComponent<PlayerMovement>().enabled = false;
        _keypad.gameObject.SetActive(true);

    }
}
