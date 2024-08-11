using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemScript : DoodadGUID, IInteractable
{
    [SerializeField] private AudioClip _pickup;
    [SerializeField] private AudioSource _source;
    public Transform inventorySpot;


    public void Interact(GameObject objAttemptingInteraction)
    {
        if (objAttemptingInteraction != null)
        {
            transform.position = inventorySpot.position;
            _source.Play();
            
        }
    }
}
