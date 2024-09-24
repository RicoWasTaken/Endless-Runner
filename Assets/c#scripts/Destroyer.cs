using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // much like the start and update methods, Ontrigger2D is a special unity method called by unity automatically at a specific point
    // in this case, when something enters the trigger attached to this gameobject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the gameobject thats collided with our trigger is tagged with cleanup..
        if (collision.gameObject.tag == "CleanUp")
        {
            Destroy(collision.gameObject);
        }
    }
}
