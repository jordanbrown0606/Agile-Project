using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keypad : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _exitKey;

    private float _btnClicked = 0f;
    private float _numGuesses;

    public string curPassword;
    public string input;
    public TMP_Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        _btnClicked = 0f;

        _numGuesses = curPassword.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (_btnClicked == _numGuesses)
        {
            if (input == curPassword)
            {
                Debug.Log("Correct Password");
                input = "";
                _btnClicked = 0f;
                displayText.text = input.ToString();
                _exitKey.GetComponent<ItemScript>().Interact(_player);
                ExitKeypad();
            }
            else
            {
                input = "";
                displayText.text = input.ToString();
                _btnClicked = 0f;
            }
        }
    }

    public void ValueEntered(string valueEntered)
    {
        switch  (valueEntered)
        {
            case "Q":
                _btnClicked = 0f;
                input = "";
                displayText.text = input.ToString();
                ExitKeypad();
                break;
            default:
                _btnClicked++;
                input += valueEntered;
                displayText.text = input.ToString();
                break;
        }
    }

    private void ExitKeypad()
    {
        _player.GetComponent<PlayerMovement>().enabled = true;
        this.gameObject.SetActive(false);
    }
}
