using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCollider : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // The beauty of using the singleton pattern i.e. having a static variable
        // on a class that holds a reference to the (single) object/instance of 
        // that class.
        // To access any public function/property on the LevelManager object I 
        // simply go
        //      LevelManager.instance.XYZ
        LevelManager.instance.SwitchTileMap();
    }
}
