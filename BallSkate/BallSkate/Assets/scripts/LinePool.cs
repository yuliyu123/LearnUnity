using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinePool : MonoBehaviour
{
    public GameObject columnPrefab;                                 //The column game object.
    public int columnPoolSize = 5;                                  //How many columns to keep on standby.
    public float spawnRate = 3f;                                    //How quickly columns spawn.
    public float columnMin = -3f;                                   //Minimum y value of the column position.
    public float columnMax = 1.5f;                                  //Maximum y value of the column position.

    private GameObject[] columns;                                   //Collection of pooled columns.
    private int currentColumn = 0;                                  //Index of the current column in the collection.

    private Vector2 objectPoolPosition = new Vector2 (-15,-25);     //A holding position for our unused columns offscreen.
    private float spawnXPosition = 10f;

    private float timeSinceLastSpawned;
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnPoolSize];
        for(int i = 0; i < columnPoolSize; i++)
        {
            //...and create the individual columns.
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.instance.gameOver == false)
        {
            //Set a random y position for the column
            float spawnYPosition = Random.Range(columnMin, columnMax);

            //...then set the current column to that position.
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
        }
    }
}
