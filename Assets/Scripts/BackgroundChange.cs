using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{

    [SerializeField] private Animator background;    
    
    
    [SerializeField] private string backgroundChanging = "BackgroundColourChange"; //allows for you to change the animation. this means this script could be used in other scenarios



        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player") == true) //checks if the object collided with is the player
            {
                background.Play(backgroundChanging, 0, 0.0f); //plays the animation with 0 delay
                Debug.Log("Background should change: ");
                Destroy(gameObject); //destroys the trigger, so not to trigger the animation again
        }

        }
    
}
