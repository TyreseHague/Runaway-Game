using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameTimer : MonoBehaviour
{
    // Editable in Unity 
    public float timeLimit; // number of seconds the game lasts
    public string nextScene; // Scene to be loaded when time runs out 

    private float startTime; // Time when the timer started



    // Called before first frame 
    void Start()
    {
        // Set the start time for when this object was created
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate how much time has passed
        float timePassed = Time.time - startTime;

        // Check if the time limit is done
        if (timePassed >= timeLimit)
        {
            // Load next scene
            SceneManager.LoadScene(nextScene);
        }
        //dog game

    }
}