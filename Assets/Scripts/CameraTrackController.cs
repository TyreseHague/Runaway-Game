using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackController : MonoBehaviour
{
    // Public
    public Transform target;
    public float smoothSpeed = 1f;

    // Private
    bool tracking = false;

    public float mapValue(float value, float istart, float istop, float ostart, float ostop, bool clamp) {
        float returnValue = ostart + (ostop - ostart) * ((value - istart) / (istop - istart));
        if (clamp)
        {
            returnValue = Mathf.Clamp(returnValue,ostart,ostop);
        }
        return returnValue;
    }

    void FixedUpdate()
    {
        Vector3 _offset = new Vector3(0, 0, 0);
        Vector3 _desired_position = new Vector3(target.position.x,transform.position.y,transform.position.z) + _offset;

        // get the absolute distance from the camera
        float distanceFromCamera = Mathf.Abs(transform.position.x - target.transform.position.x);
        
        // smoothly track the camera to the player
        float actualSmoothSpeed = mapValue(distanceFromCamera,1,4,0,smoothSpeed,false);
        Vector3 _smoothed_position = Vector3.Lerp(transform.position, _desired_position,smoothSpeed*(Time.deltaTime*(Mathf.Max(5,Vector3.Distance(transform.position,_desired_position)))));
        
        // Check if it should track
        if (distanceFromCamera > 4 || tracking && distanceFromCamera > 3)
            tracking = true;
        else
            tracking = false;

        // Move camera if tracking
        if (tracking) 
            transform.position = _smoothed_position;
    }
}
