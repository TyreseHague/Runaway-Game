using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    //public variable of the amount of time till the object is destroyed
    public float interval;

    void Start()
    {
        //destroys the object after the set amount of time
        Destroy(gameObject, interval);
    }



}
