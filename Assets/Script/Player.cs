using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public Rigidbody2D rigid;
    public BoxCollider2D boxColider;

    void Start()
    {
        instance = this;
        rigid = GetComponent<Rigidbody2D>();
        boxColider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
    }
}
