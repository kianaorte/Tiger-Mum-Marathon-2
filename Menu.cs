using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    public void StartGrass()
    {
        //retrieves the first level (Set up in the game queue)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartCactus()
    {
        //retrieves the second level (Set up in the game queue)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Quit()
    {
        //quits game, you can't see this in unity editor so I printed a debug log instead so you can see the functionality in the console
        Debug.Log("User quit the game!");
        Application.Quit();
    }

}


