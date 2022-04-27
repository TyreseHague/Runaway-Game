using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{

    public float alphaLevel = .5f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player") == true) //checks if the object collided with is the player
                alphaLevel -= .5f;

            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaLevel);
        }
    }
}
