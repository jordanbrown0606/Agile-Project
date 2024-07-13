using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Transform _lobbyKey;
    [SerializeField] private Transform _exitKey;
    [SerializeField] private Transform _safeClue;
    
    private Collider _inventorySpace;
    private bool _lobbyKeyBool;
    private bool _exitKeyBool;
    private bool _safeClueBool;

    public TMP_Text inventoryText;

    // Start is called before the first frame update
    void Start()
    {
        _inventorySpace = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_inventorySpace.bounds.Contains(_lobbyKey.transform.position))
        {
            if(_lobbyKeyBool == false)
            {
                inventoryText.text += _lobbyKey.name.ToString() + "\n";
                _lobbyKeyBool = true;
            }
        }

        if(_inventorySpace.bounds.Contains(_exitKey.transform.position))
        {
            if(_exitKeyBool == false)
            {
                inventoryText.text += _exitKey.name.ToString() + "\n";
                _exitKeyBool = true;
            }
        }

        if(_inventorySpace.bounds.Contains(_safeClue.transform.position))
        {
            if(_safeClueBool == false)
            {
                inventoryText.text += _safeClue.name.ToString() + " (F to Toggle)" + "\n";
                _safeClueBool = true;
            }


        }
    }
}
