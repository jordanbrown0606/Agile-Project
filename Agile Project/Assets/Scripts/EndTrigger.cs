using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject ending;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ending.SetActive(true);
            other.GetComponent<CharacterController>().enabled = false;
        }
    }
}
