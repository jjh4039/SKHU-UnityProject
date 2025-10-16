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
        // 날개짓, 위아래 이동 코루틴 반복
        StartCoroutine(Move());
    }

    public void Update()
    {
        // 좌측 이동
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

    // 총알과 충돌 시 오브젝트 삭제
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            // Bullet_Move 스크립트에서 해결
            // gameObject.SetActive(false);
        }
    }
}
