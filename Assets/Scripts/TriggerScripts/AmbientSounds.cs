using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSounds : MonoBehaviour
{
    public AudioSource playSound; //sets a public variable, this will allow you to change the sound in engine.

    void OnTriggerEnter2D(Collider2D collision) //when a collision happens with the object the script is attached to, this will be called
    {
        if (collision.CompareTag("Player") == true) //checks if the object collided with is the player
            playSound.Play(); //plays the sounds
    }

}
