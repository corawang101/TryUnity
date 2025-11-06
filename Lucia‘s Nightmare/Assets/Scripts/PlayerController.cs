using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChracterMovement : MonoBehaviour
{
    public float playerMoveSpeed;
    public Rigidbody2D playerRB;
    public Collider2D playerColl;

    void Start()
    {
        playerColl = GetComponent<Collider2D>();
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float horizontalNum = Input.GetAxis("Horizontal");
        float faceNum = Input.GetAxisRaw("Horizontal");
        playerRB.linearVelocity = new Vector2(playerMoveSpeed * horizontalNum,playerRB.linearVelocity.y);
        if (faceNum != 0)
        {
            transform.localScale = new Vector3(-faceNum * horizontalNum, transform.localScale.y, transform.localScale.z);
        }
    }
}
