using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const string HORIZONTALID = "Horizontal";
    private const string JUMPID = "Jump";

    [SerializeField] private float _movementSpeed = 1;
    [SerializeField] private float _jumpHeight = 1;
    [SerializeField] private Feet feet;

    private Rigidbody2D _rigidbody;

    //Unity controlled function
    private void Awake() 
    {
        
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    //Unity controlled function
    private void Update() 
    {
        Move();
        
    }

    private void Move()
    {
        if(Input.GetAxis(HORIZONTALID) > Mathf.Epsilon) { TranslatePlayer(new Vector2(1,0)); }
        if(Input.GetAxis(HORIZONTALID) < 0) { TranslatePlayer(new Vector2(-1,0)); }
       // if(Input.GetButtonUp(HORIZONTALID)) { _rigidbody.velocity = new Vector2(0,_rigidbody.velocity.y); }
        if(Input.GetButtonDown(JUMPID) && feet.CollidingOnGround) { transform.position += new Vector3(0,1f,0); TranslatePlayer(new Vector2(0,_jumpHeight)); }
    }

    private void TranslatePlayer(Vector2 amount)  =>  _rigidbody.velocity += amount * Time.deltaTime * _movementSpeed;
}
