using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{

    void Start()
    {
        Cursor.visible = false;   
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown (KeyCode.Escape))
        {
            Cursor.visible = true;
        }
        transform.position = Input.mousePosition;
    }
}
