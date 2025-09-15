using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Man_Move : MonoBehaviour
{
    public Rigidbody2D rigid;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(new Vector2(0, 5f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-10 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigid.AddForce(new Vector2(0, -5f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(10 * Time.deltaTime, 0, 0);
        }
    }
}
