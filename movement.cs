using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 10f;
    public float move;
    private Rigidbody2D player;

    bool grounded = false;
    public Transform groundCheck;
    public float groundSize = 0.2f;
    public bool isGrounded = false;
    public LayerMask whatGround;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundSize);

        //retrieves value of the horizontal/x axis
        move = Input.GetAxis("Horizontal");
        //moves/gives player velocity to the x axis where the y stays the same
        player.velocity = new Vector2(move * speed, player.velocity.y);
    }
}
