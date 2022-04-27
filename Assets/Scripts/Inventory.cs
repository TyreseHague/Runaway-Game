using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int notes;
    public TMPro.TextMeshProUGUI noteCounterText;

    // Start is called before the first frame update
    void Start()
    {
        notes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        noteCounterText.text = "Notes: " + notes;
    }

    public int GetNotes()
    {
        return notes;
    }

}
