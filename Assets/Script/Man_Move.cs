using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Man_Move : MonoBehaviour
{
 
    void Update()
    { 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.01f, 0, 0);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.01f, 0, 0);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.01f, 0);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.01f, 0);
        }
    }
}
