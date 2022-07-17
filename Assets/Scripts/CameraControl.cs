using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float speed;
    private Vector3 velocity = Vector3.zero;
    //Follw player
    public Transform player;
    

    void Update()
    {
        //Follow Player
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
