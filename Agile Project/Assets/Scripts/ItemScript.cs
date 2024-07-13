using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemScript : DoodadGUID, IInteractable
{
    
    public Transform inventorySpot;


    public void Interact(GameObject objAttemptingInteraction)
    {
        if (objAttemptingInteraction != null)
        {
            transform.position = inventorySpot.position;
        }
    }
}
