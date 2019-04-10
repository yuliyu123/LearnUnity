using UnityEngine;
using System.Collections;

public class Column : MonoBehaviour 
{
    // 
    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("enter OnTriggerEnter2D");
        if(other.GetComponent<Bird>() != null)
        {
            Debug.Log("enter OnTriggerEnter2D with bird");
            //If the bird hits the trigger collider in between the columns then
            //tell the game control that the bird scored.
            GameControl.instance.BirdScored();
        }
    }
}