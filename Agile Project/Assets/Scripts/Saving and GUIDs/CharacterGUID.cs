using UnityEngine;

/// <summary>
/// All characters have health.
/// Is a type of GUIDObject so it has a GUID with which it can be saved and loaded.
/// </summary>
public class CharacterGUID : GUIDObject
{
    [SerializeField] protected int _health;

    protected bool _isDead;

    public int Health { get { return _health; } set { _health = value; } }
    public bool isDead { get { return _isDead; } set { _isDead = value; } }
}

