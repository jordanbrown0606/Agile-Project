using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGUID : GUIDObject
{
    [SerializeField] protected bool _hasWeapon;

    public bool HasWeapon { get { return _hasWeapon; } set { _hasWeapon = value; } }
}
