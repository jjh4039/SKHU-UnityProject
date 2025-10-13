using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Move : MonoBehaviour
{
    public Rigidbody2D rigid;
    public GameObject pfEffect;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Instantiate(pfEffect, transform.position, transform.rotation);
        }
    }
    void Update()
    {
        rigid.AddForce(new Vector2(50f*Time.deltaTime, 0f), ForceMode2D.Impulse);
    }
}
