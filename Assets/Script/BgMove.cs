using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMove : MonoBehaviour
{
    float speed = 0;

    void Start()
    {
        
    }

   
    void Update()
    {
        speed = Time.deltaTime * 5;
        transform.Translate(-speed, 0, 0);
        if(transform.position.x < -9)
        {
            transform.position = new Vector3(9.0f, transform.position.y, transform.position.z);
        }
    }
}
