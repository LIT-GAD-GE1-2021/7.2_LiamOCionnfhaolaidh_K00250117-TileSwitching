using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    public GameObject tileMapA;
    public GameObject tileMapB;
    public GameObject tileMapC;

    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            // Simply a demonstration of what one could do

            // Activate tileMapB
            tileMapB.SetActive(false);

            // Toggle the active state of tileMapC
            tileMapC.SetActive(!tileMapC.activeSelf);
        }
    }

    // Switches between tileMapA and tileMapB
    public void SwitchTileMap()
    {
        if (tileMapB.activeSelf == true)
        {
            tileMapB.SetActive(false);
        }
        else
        {
            tileMapB.SetActive(true);
        }
    }

}
