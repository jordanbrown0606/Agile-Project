using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour, IInteractable
{
    public void Interact(GameObject objAttemptingInteraction)
    {
        if (objAttemptingInteraction.GetComponent<PlayerInteraction>() != null)
        {
            objAttemptingInteraction.GetComponent<PlayerInteraction>().WeaponPickup(gameObject);
            this.gameObject.GetComponent<WeaponGUID>().HasWeapon = true;
        }
    }
}
