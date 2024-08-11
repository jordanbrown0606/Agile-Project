using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemScript : DoodadGUID, IInteractable
{
    [SerializeField] AudioClip _pickup;
    private AudioSource _source;
    public Transform inventorySpot;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
        _source.clip = _pickup;
    }


    public void Interact(GameObject objAttemptingInteraction)
    {
        if (objAttemptingInteraction != null)
        {
            transform.position = inventorySpot.position;
            _source.Play();
            
        }
    }
}
