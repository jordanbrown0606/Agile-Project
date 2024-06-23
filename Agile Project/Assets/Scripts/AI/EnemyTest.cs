using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : CharacterGUID, IDamageable
{
    public void TakeDamage(int amount)
    {
        _health -= amount;

        if (_health <= 0)
        {
            this.gameObject.GetComponent<Agent>().Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
