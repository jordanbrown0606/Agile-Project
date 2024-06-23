using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the save and load.
/// Protip: This script is bad and should not handle that stuff.
/// Maybe you should use an input manager instead.
/// </summary>

public class Player : CharacterGUID, IDamageable
{
    public void TakeDamage(int amount)
    {
        _health -= amount;
    }
}
