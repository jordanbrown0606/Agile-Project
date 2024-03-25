using UnityEngine;

/// <summary>
/// All characters have health.
/// Is a type of GUIDObject so it has a GUID with which it can be saved and loaded.
/// </summary>
public class CharacterGUID : GUIDObject
{
    [SerializeField] protected int _health;

    public int Health { get { return _health; } set { _health = value; } }
}

