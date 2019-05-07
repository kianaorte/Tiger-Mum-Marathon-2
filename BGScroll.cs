using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour{
    private float startingposition, maplength;
    public GameObject cam;
    public float camMotion;
    

    void Start() {
        startingposition = transform.position.x;
        maplength = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    //Updates/changes the position of each layer to apply a parallax effect
    void FixedUpdate() {
        //sets the speeds of each layer of the background and how they move
        float temp = (cam.transform.position.x * (1 - camMotion));
        float dist = (cam.transform.position.x * camMotion);
        transform.position = new Vector3(startingposition + dist, transform.position.y, transform.position.z);


        //This causes the map to loop infinitely
        if (temp >startingposition + maplength) {
            startingposition += maplength;
        } else if(temp < startingposition - maplength) {
            startingposition -= maplength;
        }

    }
}
