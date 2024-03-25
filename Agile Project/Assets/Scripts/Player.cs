using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the save and load.
/// Protip: This script is bad and should not handle that stuff.
/// Maybe you should use an input manager instead.
/// </summary>

public class Player : CharacterGUID
{
    // Update is called once per frame
    void Update()
    {
        // Send a message to SaveLoad that will make a binary file of the passed name of this file.
        //Generate a new game data based on the current game state.
        // Save the game data in the generated file.
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveLoad.Save("SaveFile", new GameData());
        }

        if (Input.GetKeyDown(KeyCode.L))
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
}
