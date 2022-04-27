using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTest : MonoBehaviour
{

    public KeyCode increaseAlpha;
    public KeyCode decreaseAlpha;
    public float alphaLevel = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(increaseAlpha))
            alphaLevel += .05f;        
        
        
        if (Input.GetKeyDown(decreaseAlpha))
            alphaLevel -= .05f;

        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaLevel);
    }
}