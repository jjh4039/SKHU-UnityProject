using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Ctrl : MonoBehaviour
{
    float currentTime = 0f;
    float offsetTime = 2.0f;

    public GameObject pfBat;

    private void Update()
    {
        currentTime = currentTime + Time.deltaTime;

        if (currentTime > offsetTime)
        {
            currentTime = 0f;
            Instantiate(pfBat, transform.position, transform.rotation);
        }
    }
}
