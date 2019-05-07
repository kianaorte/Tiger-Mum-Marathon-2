using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointSystem : MonoBehaviour
{

    public static int userScore = 0;
    Text scoreValue;

    void Start()
    {
        scoreValue = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue.text = "Score: " + scoreValue;
    }
}
