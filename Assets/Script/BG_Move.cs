using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Move : MonoBehaviour
{
    public Transform playerPos;
    public SpriteRenderer spriteBG;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(playerPos.position.x, playerPos.position.y, this.transform.position.z);
        spriteBG.material.mainTextureOffset = new Vector2(playerPos.position.x * 0.01f, 1f) ;
    }
}
