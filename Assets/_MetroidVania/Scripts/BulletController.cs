using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D _theBulletRB;

    private float _bulletSpeed = 10;

    public Vector2 moveDirection;

    private void Awake()
    {
        _theBulletRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _theBulletRB.velocity = moveDirection * _bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
