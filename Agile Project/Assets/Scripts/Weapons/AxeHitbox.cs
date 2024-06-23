using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeHitbox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            other.transform.GetComponent<IDamageable>()?.TakeDamage(5);
        }
    }
}
