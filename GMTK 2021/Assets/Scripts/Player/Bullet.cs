using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    Rigidbody2D _rigidbody2D;

    private void Awake() 
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() 
    {
        _rigidbody2D.velocity = new Vector2((_speed * Time.deltaTime) * transform.localScale.x,0);
    }
}
