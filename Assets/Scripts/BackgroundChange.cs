using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{

    [SerializeField] private Animator background;    
    
    
    [SerializeField] private string backgroundChanging = "backgroundChange";



    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player") == true) //checks if the object collided with is the player
            {
                backgroundImage.Play(background, 0, 0.0f);
            }

        }
    }
}
