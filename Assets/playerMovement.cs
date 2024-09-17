using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // create a ref to the rigidbody2d so we can manipulate it
    Rigidbody2D playerObject;
    public float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
       // find the rigidbody2d component that is attatched to the same object as this script 
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // create a float that will be equal to the player's horizontal input
        float movementValueX = Input.GetAxis("Horizontal");
        float movementValueY = Input.GetAxis("Vertical");

        // change the x velocity of the rigidbody2d to be equal to the movement value 
        playerObject.velocity = new Vector2 (movementValueX * speed , playerObject.velocity.y);
        playerObject.velocity = new Vector2(playerObject.velocity.x , movementValueY * speed);

    }
}
