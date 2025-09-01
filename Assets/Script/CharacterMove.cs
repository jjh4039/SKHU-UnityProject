using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    Rigidbody2D player;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            player.velocity = new Vector2(0, 3.0f);
        }
    }
}
