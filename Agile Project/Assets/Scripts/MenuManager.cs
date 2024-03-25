using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject optionsMenu;

    // Update is called once per frame
    void Update()
    {
        // Toggle for the in-game menu, bound to the escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            optionsMenu.SetActive(!optionsMenu.activeSelf);
        }
    }

    public void SaveGame()
    {
        // Send a message to SaveLoad that will make a binary file of the passed name of this file.
        //Generate a new game data based on the current game state.
        // Save the game data in the generated file.
        SaveLoad.Save("SaveFile", new GameData());
    }

    public void LoadGame()
    {
        // Send a request to SaveLoad to find a file of the passed name.
        // If the file is not found it will return null.
        GameData gd = SaveLoad.Load("SaveFile");

        // The file was not found, return null.
        if (gd == null)
        {
            return;

        }
        // Send a message to GameData to set the values of the stored GUID objects position, rotation, health, and mana.
        gd.LoadGUIDData();
    }
}
