using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{

    private GameObject currentTeleporter;

    // Update is called once per frame
    void Update()
    {
        if(currentTeleporter != null)
        {
            transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = null; 
        }
    }
}
