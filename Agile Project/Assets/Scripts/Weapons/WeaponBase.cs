using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour, IInteractable
{
    public bool hasWeapon;

    public void Interact(GameObject objAttemptingInteraction)
    {
        if (objAttemptingInteraction.GetComponent<PlayerInteraction>() != null)
        {
            objAttemptingInteraction.GetComponent<PlayerInteraction>().WeaponPickup(gameObject);
            hasWeapon = true;
        }
    }
}
