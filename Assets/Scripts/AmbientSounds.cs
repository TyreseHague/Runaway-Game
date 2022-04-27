using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSounds : MonoBehaviour
{
    public AudioSource playSound;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true) //checks if the object collided with is the player
            playSound.Play();
    }

}
