using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    public static GameControl instance;  
    public bool gameOver = false;
    public float scrollSpeed = 1.5f;

    void Awake()
    {
        //If we don't currently have a game control...
        if (instance == null)
            //...set this one to be it...
            instance = this;
        //...otherwise...
        else if(instance != this)
            //...destroy this one because it is a duplicate.
            Destroy (gameObject);
    }

    void Update()
    {
        //If the game is over and the player has pressed some input...
        if (gameOver && Input.GetMouseButtonDown(0)) 
        {
            //...reload the current scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
