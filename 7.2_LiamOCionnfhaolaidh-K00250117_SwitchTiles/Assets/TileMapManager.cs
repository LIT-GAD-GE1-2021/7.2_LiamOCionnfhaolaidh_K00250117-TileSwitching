using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapManager : MonoBehaviour
{

    public static TileMapManager instance;

    public GameObject tileMap1;
    public GameObject tileMap2;





    private void Awake()
    {

        instance = this;

    }


    public void TileMapControl()
    {

        if (tileMap2.activeSelf == true)
        {
            tileMap2.SetActive(false);

            tileMap1.SetActive(true);

        }
        else if (tileMap1.activeSelf == true)
        {
            
            tileMap2.SetActive(true);

            tileMap1.SetActive(false);

        }


    }



    // Start is called before the first frame update
    void Start()
    {
        tileMap1.SetActive(true);
        tileMap2.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
