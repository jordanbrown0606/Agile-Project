using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueScript : MonoBehaviour
{
    [SerializeField] private GameObject _clue;

    // Update is called once per frame
    void Update()
    {
        if(transform.position == GetComponent<ItemScript>().inventorySpot.position)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                _clue.SetActive(!_clue.activeSelf);
            }
        }
    }
}
