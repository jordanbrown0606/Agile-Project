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
    private string _lobbyKeyText;
    private string _exitKeyText;
    private string _safeClueText;

    public TMP_Text inventoryText;

    // Start is called before the first frame update
    void Start()
    {
        _inventorySpace = GetComponent<Collider>();
        _lobbyKeyText = _lobbyKey.name.ToString() + "\n";
        _exitKeyText = _exitKey.name.ToString() + "\n";
        _safeClueText = _safeClue.name.ToString() + " (F to Toggle)" + "\n";
    }

    // Update is called once per frame
    void Update()
    {
        if(_inventorySpace.bounds.Contains(_lobbyKey.transform.position))
        {
            if(_lobbyKeyBool == false)
            {
                inventoryText.text += _lobbyKeyText;
                _lobbyKeyBool = true;
            }
        }
        else
        {
            _lobbyKeyBool = false;
            inventoryText.text = "Inventory: ";
        }

        if(_inventorySpace.bounds.Contains(_exitKey.transform.position))
        {
            if(_exitKeyBool == false)
            {
                inventoryText.text += _exitKeyText;
                _exitKeyBool = true;
            }
        }
        else
        {
            _exitKeyBool = false;
            inventoryText.text = inventoryText.text.Replace(_exitKeyText, "");
        }

        if(_inventorySpace.bounds.Contains(_safeClue.transform.position))
        {
            if(_safeClueBool == false)
            {
                inventoryText.text += _safeClueText;
                _safeClueBool = true;
            }

        }
        else
        {
            _safeClueBool = false;
            inventoryText.text = inventoryText.text.Replace(_safeClueText, ""); ;
        }
    }
}
