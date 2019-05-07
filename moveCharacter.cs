using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour
{
    // private Vector3 startingposition = new Vector3 (1.4, -5.56, 10);
    private Vector2 position;
    public float height, speed;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, position, speed);
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            //when the user pushes the up key, the character moves up based on the jump's height (set as a input in the controller so it's easier to tweak)
            position = new Vector2(transform.position.x, transform.position.y + height); 

            //add fall
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            //when the user pushes the down key, the character moves down based on the jump's height
            position = new Vector2(transform.position.x, transform.position.y - height);
        }
        
    }
}
