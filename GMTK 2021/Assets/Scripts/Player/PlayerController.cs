using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float MovX;
    private float MovY;
    public float MoveSpeed;
    public float JumpForce;
    public bool Jumping;

    private Rigidbody2D RG2D;

    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        RG2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MovX = Input.GetAxisRaw("Horizontal");
        MovY = Input.GetAxisRaw("Vertical");

        if(MovX != 0)
         { 
              RG2D.velocity = new Vector2(MovX * MoveSpeed, RG2D.velocity.y);
               _spriteRenderer.transform.localScale = MovX < Mathf.Epsilon ? new Vector3(-1,1,1) : new Vector3(1,1,1);
              }
        else if(MovX == 0) RG2D.velocity = new Vector2(RG2D.velocity.x / 2, RG2D.velocity.y);
        
        if(MovY == 1 && !Jumping)
        {
            RG2D.velocity = new Vector2(RG2D.velocity.x, JumpForce);
            Jumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Jumping = false;
    }
}
