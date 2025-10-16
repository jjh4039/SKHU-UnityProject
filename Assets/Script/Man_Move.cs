using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Man_Move : MonoBehaviour
{
    public Rigidbody2D rigid;

    void Update()
    {
        // �̵� ����
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
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

    // ���Ϳ� �浹, ���� �� ���� �����
    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Enemy":
                SceneManager.LoadScene(0);
                break;
            case "Goal":
                SceneManager.LoadScene(0);
                break;
            default:
                break;
        }
    }
}
