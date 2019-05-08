using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMap : MonoBehaviour
{
    //map scrolls at the speed of 0.5 but it can be altered in the Unity editor
    public Transform target;
    public float moveSpeed = 0.5f;
    public float distance = 30.0f;

    private void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / distance);
    }
    
    private void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
