using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public AudioClip notePickup;

    void OnTriggerEnter2D(Collider2D col){
        GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Inventory>().notes++;

        AudioSource.PlayClipAtPoint(notePickup,transform.position,1f); // play the note pickup noise at the position of the note when its picked up
        
        Destroy(this);
        Destroy(gameObject);
    }
}
