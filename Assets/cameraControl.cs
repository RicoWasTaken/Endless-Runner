using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    // chreate a public reference to the unity editor, we can assign this to the player in unity
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        // change our position relative to the player's position
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}
