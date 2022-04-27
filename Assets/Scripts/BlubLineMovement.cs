using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlubLineMovement : MonoBehaviour
{
    public float forceStrength; //How fast the entity moves
    public Vector2 direction; //what direction the entity moves

    private Rigidbody2D ourRigidbody; //the container for the object


    void Awake()
    {
        // Get the rigidbody that we'll be using for movement
        ourRigidbody = GetComponent<Rigidbody2D>();

        // Normalise our direction
        // Normalise changes it to be length 1, so we can later multiply it by our speed / force
        direction = direction.normalized;
    }


    // Update is called once per frame
    void Update()
    {
        // Move in the correct direction with the set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
