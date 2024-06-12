using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _theRB;

    [Header("Player Movment")]
    public float moveSpeed;
    public float jumpForce;

    private void Awake()
    {
        _theRB = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        float _xInput = Input.GetAxisRaw("Horizontal");
        _theRB.velocity = new Vector2(_xInput * moveSpeed, _theRB.velocity.y);
    }
}
