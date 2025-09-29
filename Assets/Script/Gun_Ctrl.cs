using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Ctrl : MonoBehaviour
{
    [SerializeField] GameObject pfBullet;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pfBullet, transform.position, transform.rotation);
        }
    }
}
