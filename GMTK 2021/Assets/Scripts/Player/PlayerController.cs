using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private float MovX;
    private float MovY;
    public float MoveSpeed;
    public bool Jumping;
    public DamageDealingModule bullet;

    private Rigidbody2D RG2D;
    public Animator Animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] public SpriteRenderer spriteRenderer;
    public InformationContainer container;

    private void Start()
    {
        RG2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        container.unlockedUpgrades.ForEach(i => i.Invoke(this));
        MovX = Input.GetAxisRaw("Horizontal");
        if (MovX != 0)
        {
            RG2D.velocity = new Vector2(MovX * MoveSpeed, RG2D.velocity.y);
            _spriteRenderer.transform.localScale = MovX < Mathf.Epsilon ? new Vector3(-1f, 1, 1) : new Vector3(1f, 1, 1);
            spriteRenderer.transform.localScale = MovX < Mathf.Epsilon ? new Vector3(-1f, 1, 1) : new Vector3(1f, 1, 1);
            Animator.Play("PlayerWalk");
        }
        else if (MovX == 0)
        {
            RG2D.velocity = new Vector2(RG2D.velocity.x / 2, RG2D.velocity.y);
            Animator.Play("Idle");
        }

        if ((Input.GetButtonDown("Vertical") || Input.GetButtonDown("Jump")) && !Jumping)
        {
            RG2D.velocity = new Vector2(RG2D.velocity.x, container.jumpHeight);
            Jumping = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Jumping = false;
    }
    public T PCInstantiate<T>(T go) where T : UnityEngine.Object => Instantiate(go) as T;
}