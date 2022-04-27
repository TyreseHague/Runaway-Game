using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    // Public
    public CharacterController2D controller;
    public Sprite[] animation_sprites;
    public float walkSpeed = 40f;
    public float sprintMultiplier = 2.3f;

    // Private    
    float horizontalMove = 0;
    bool jump = false;
    bool running = false;

    int animation_index = 0;

    float distance_traveled = 0;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            running = true;
        }

        horizontalMove = Input.GetAxisRaw("Horizontal") * walkSpeed * (running ? sprintMultiplier : 1f);



        // check if the character wants to jump
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        //update sprite
        if (horizontalMove != 0)
        {
            distance_traveled += Mathf.Abs(horizontalMove * Time.deltaTime);

            if (distance_traveled > 0.9)
            {
                distance_traveled = 0;
                animation_index++;
                if (animation_index >= animation_sprites.Length)
                {
                    animation_index = 0;
                }
                GetComponent<SpriteRenderer>().sprite = animation_sprites[animation_index];
            }
        }
        else
        {
            if (animation_index != 0)
            {
                animation_index = (animation_index + 1) % animation_sprites.Length;
            }
            GetComponent<SpriteRenderer>().sprite = animation_sprites[animation_index];
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        running = false;
    }
}
