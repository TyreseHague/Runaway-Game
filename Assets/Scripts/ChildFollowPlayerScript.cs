using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildFollowPlayerScript : MonoBehaviour
{

    // Public
    public Transform target;
    public float smoothSpeed = 1f;
    public Sprite[] animation_sprites;
    
    // Private
    bool tracking = false;
    bool m_FacingRight;
    int animation_index = 0;
    float distance_traveled = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_FacingRight = false;
    }

    public float mapValue(float value, float istart, float istop, float ostart, float ostop, bool clamp) {
        float returnValue = ostart + (ostop - ostart) * ((value - istart) / (istop - istart));
        if (clamp)
        {
            returnValue = Mathf.Clamp(returnValue,ostart,ostop);
        }
        return returnValue;
    }

    // Update is called once per frame
    void Update()
    {
        // check if the player is to the left or right of the child

        if (transform.position.x < target.position.x)
        {
            Vector3 theScale = transform.localScale;
            theScale.x = 0.4f;
            transform.localScale = theScale;
        } else if (transform.position.x > target.position.x) {
            Vector3 theScale = transform.localScale;
            theScale.x = -0.4f;
            transform.localScale = theScale;
        }
    }

    void FixedUpdate()
    {
        Vector3 _offset = new Vector3(0, 0, 0);
        Vector3 _desired_position = new Vector3(target.position.x,transform.position.y,transform.position.z) + _offset;

        // get the absolute distance from the player
        float distanceFromPlayer = Mathf.Abs(transform.position.x - target.transform.position.x);
        
        // smoothly track the child to the player
        float actualSmoothSpeed = mapValue(distanceFromPlayer,0,4,0,smoothSpeed,false);
        Vector3 _smoothed_position = Vector3.Lerp(transform.position, _desired_position,smoothSpeed*(Time.deltaTime*(Mathf.Max(4,Vector3.Distance(transform.position,_desired_position)))));
        
        // Check if it should track
        if (distanceFromPlayer > 5 || tracking && distanceFromPlayer > 3)
            tracking = true;
        else
            tracking = false;

        // Move child if tracking
        if (tracking) {
            distance_traveled += Mathf.Abs((transform.position.x - _smoothed_position.x));

            if (distance_traveled > 0.25)
            {
                distance_traveled = 0;
                animation_index++;
                if (animation_index >= animation_sprites.Length)
                {
                    animation_index = 0;
                }
                GetComponent<SpriteRenderer>().sprite = animation_sprites[animation_index];
            }

            transform.position = _smoothed_position;
        } else {
            animation_index = 0;
        }
    }
}
