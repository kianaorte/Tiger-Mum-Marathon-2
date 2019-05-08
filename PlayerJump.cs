using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour
{

    private Rigidbody2D player;

    public bool grounded = true;
    public float jumpPower = 300;
    private bool hasJumped = false;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!grounded && player.velocity.y == 0 && hasJumped == false)
        {
            grounded = true;
        }
        if (Input.GetKey(KeyCode.UpArrow) | (Input.GetKey(KeyCode.W)) && grounded == true)
        {
            hasJumped = true;
        }
    }

    void FixedUpdate()
    {
        if (hasJumped)
        {
            player.AddForce(transform.up * jumpPower);
            grounded = false;
            hasJumped = false;
        }
    }
}
