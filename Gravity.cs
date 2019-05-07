using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float jumpHeight = 30.0f;
    public Transform groundCheck;

    //Prepares values to use the OverlapCircle function
    public float groundSize = 0.2f;
    public bool isGrounded = false;
    public LayerMask whatGround;
   

    void FixedUpdate()
    {
        bool jump = Input.GetKey(KeyCode.UpArrow);
        //Creates a circle at the players position to see if any terrain collides with the player's hitbox
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundSize, whatGround);

        if (jump) GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpHeight);
    }
}
