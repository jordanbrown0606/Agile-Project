using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Handles the save and load.
/// Protip: This script is bad and should not handle that stuff.
/// Maybe you should use an input manager instead.
/// </summary>

public class Player : CharacterGUID, IDamageable
{
    public GameObject deathScreen;

    public void TakeDamage(int amount)
    {
        _health -= amount;
    }

    private void Update()
    {
        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        GetComponent<CharacterController>().enabled = false;
        deathScreen.SetActive(true);

    }
}
