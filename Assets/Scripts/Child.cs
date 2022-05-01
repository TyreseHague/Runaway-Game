using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : MonoBehaviour
{


    // Public variables, visible in Unity Inspector
    // movement variables
    public Transform pos1, pos2; //the different positions for the child
    public float speed; //speed the child will move
    public Transform startPos; //start position for the child
    //list of the game objects for the child
    public GameObject[] currentChild;    //the current model for the child being moved 
    public GameObject[] previousChild; //last child model being moved 
    Vector3 nextPos;



    // Private variables, NOT visible in the Inspector
    // ------------------------------------------------
    private int currentPoint = 0;       // Index of the current point we're moving towards
    private Rigidbody2D ourRigidbody;   // attaches rigidbody to this object



    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Player") //if the player collides with the ending object

            if (transform.position == pos1.position)
            {
                nextPos = pos2.position;
            }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);

    }

}
