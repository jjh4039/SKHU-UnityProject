using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bat_Move : MonoBehaviour
{
    // float speedX = -0.005f;
    // float speedY = 0f;
    [SerializeField] GameObject left_Bat;
    [SerializeField] GameObject right_Bat;

    private void Awake()
    {
        // ������, ���Ʒ� �̵� �ڷ�ƾ �ݺ�
        StartCoroutine(Move());
    }

    public void Update()
    {
        // ���� �̵�
        transform.Translate(-0.005f, 0f, 0f);
    }

    IEnumerator Move()
    {
        for (int i = 0; i < 50; i++)
        {
            transform.Translate(0f, -0.005f, 0f);
            left_Bat.transform.Rotate(0f, 0f, 0.5f);
            right_Bat.transform.Rotate(0f, 0f, -0.5f);
            yield return new WaitForSeconds(0.01f);
        }
        for (int i = 0; i < 50; i++)
        {
            transform.Translate(0f, 0.005f, 0f);
            left_Bat.transform.Rotate(0f, 0f, -0.5f);
            right_Bat.transform.Rotate(0f, 0f, 0.5f);
            yield return new WaitForSeconds(0.01f);
        }
        StartCoroutine(Move());
    }

    // �Ѿ˰� �浹 �� ������Ʈ ����
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            // Bullet_Move ��ũ��Ʈ���� �ذ�
            // gameObject.SetActive(false);
        }
    }
}
