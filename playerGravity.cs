using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGravity : MonoBehaviour
{
    private Rigidbody2D player;
    float move = 0.0f;
    bool jump = false;
    bool forward = false;

    //these are used for the move player function
    private Vector2 position;
    public float distance, speed;

    private void Awake()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow )|| Input.GetKey(KeyCode.W))
        {
            jump = true;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            forward = true;
        }

    }

    //exeuctes after update which leads to the character falling down after jumping up
    void FixedUpdate()
    {
        MovePlayer(jump);

    }

    public void MovePlayer(bool jump)
    {
        if (jump)
    {
            //when the user pushes the up key, the character moves up based on the jump's height (set as a input in the controller so it's easier to tweak)
            position = new Vector2(transform.position.x, transform.position.y + distance);

            //stops jumping so he doesnt end up flying
            jump = false;
        }
        
        if (jump == false)
        {
            //when the user pushes the down key, the character moves down based on the set distance
            position = new Vector2(transform.position.x, transform.position.y - distance);
        }
        if (forward)
        {
            //when the user pushes the up key, the character moves up based on the jump's height (set as a input in the controller so it's easier to tweak)
            position = new Vector2(transform.position.x + distance, transform.position.y);

            //stops jumping so he doesnt end up flying
            jump = false;
        }
    }
}
