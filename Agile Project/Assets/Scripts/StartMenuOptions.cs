using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class StartMenuOptions : MonoBehaviour
{
    [SerializeField] private GameObject _continueButton;
    private string _path;

    // Start is called before the first frame update
    void Start()
    {
        _path = Application.persistentDataPath + "/" + "SaveFile" + ".dat";
    }

    // Update is called once per frame
    void Update()
    {
        if (File.Exists(_path))
        {
            _continueButton.SetActive(true);
        }
        else
        {
            _continueButton.SetActive(false);
        }
    }
}
