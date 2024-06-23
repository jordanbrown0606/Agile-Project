using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : CharacterGUID, IDamageable
{
    public void TakeDamage(int amount)
    {
        _health -= amount;

        if (_health <= 0 )
        {
            this.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (_health <= 0 )
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
