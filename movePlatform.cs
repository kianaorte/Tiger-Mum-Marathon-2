using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlatform : MonoBehaviour {

    public Transform target;
    public float moveSpeed = 0.5f;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = target.transform.position.x - moveSpeed;
        transform.position = position;
    }

}
