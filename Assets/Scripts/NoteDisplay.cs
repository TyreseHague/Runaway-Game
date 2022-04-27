using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDisplay : MonoBehaviour
{
    //list of the game objects for the note
    public GameObject[] healthIcons;

    Inventory player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        //variable to keep track of which note on the list we are on
        int iconHealth = 0;
        //Go through each icon on the list
        //we will do everything inside the brackets for each item in the list 
        //For each styep in the loop we'll store the current list item in the "icon" variable
        foreach (GameObject icon in healthIcons)
        {
            //each icon is worth 1 more than the last
            iconHealth = iconHealth + 1;

            if (player.GetNotes() >= iconHealth)
            {
                // ...Then turn the icon ON
                icon.SetActive(true);
            }
            // Otherwise...
            // (the player's health is LESS than this icon's value)
            else
            {
                // ... Turn the icon OFF
                icon.SetActive(false);
            }
        }

    }
}
