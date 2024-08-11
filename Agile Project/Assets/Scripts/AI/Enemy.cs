using BetterFSM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CharacterGUID, IDamageable
{
    public void TakeDamage(int amount)
    {
        _health -= amount;

        if (_health <= 0)
        {
            this.gameObject.GetComponent<Agent>().Die();
            StartCoroutine(MoveBody());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_health <= 0)
        {
            this.gameObject.GetComponent<Agent>().Die();
            StartCoroutine(MoveBody());
        }
    }

    public IEnumerator MoveBody()
    {
        yield return new WaitForSeconds(1.5f);
        this.gameObject.SetActive(false);
    }
}
