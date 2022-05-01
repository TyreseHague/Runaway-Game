using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public string levelToLoad; //sets level as a public variable

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Player") //if the player collides with the ending object

            SceneManager.LoadScene(levelToLoad); //loads the next scene
    }
}
