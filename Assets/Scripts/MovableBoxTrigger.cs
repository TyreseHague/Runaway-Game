using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovableBoxTrigger : MonoBehaviour
{
    public string levelToLoad; //sets level as a public variable

    void OnTriggerEnter2D(Collider2D collision) //when a collision happens with the object the script is attached to, this will be called
    {
        if (collision.CompareTag("Box") == true) //checks if the object collided with is the player
        SceneManager.LoadScene(levelToLoad); //loads the next scene with the box in place
    }
}
