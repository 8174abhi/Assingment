using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    bool Top;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Physics.gravity = new Vector3( -9.81f,0f,0f);
           

        }

        else if(Input.GetKeyDown(KeyCode.RightArrow))

        {
            Physics.gravity = new Vector3(- 9.81f,0, 0f)

                ; }
        else if( Input.GetKeyDown(KeyCode.UpArrow))

        {
            Physics.gravity = new Vector3(0f, 9.81f, 0);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            Physics.gravity = new Vector3(0, -9.81f, 0f);
        }
       
       

    }
    void Rotation()
    {
        if (Top == false)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }
        Top = !Top;
    }
}
