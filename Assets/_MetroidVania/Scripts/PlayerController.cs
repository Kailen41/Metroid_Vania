using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _theRB;
    private Animator _playerAnim;

    [Header("Player Movement")]
    public float moveSpeed;

    [Header("Player Jump")]
    public float jumpForce;
    public Transform groundPoint;
    public LayerMask groundLayer;

    private bool _isGrounded;
    private float _overlapRadius = 0.2f;

    private void Awake()
    {
        _theRB = GetComponent<Rigidbody2D>();
        _playerAnim = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        float _xInput = Input.GetAxisRaw("Horizontal");
        _theRB.velocity = new Vector2(_xInput * moveSpeed, _theRB.velocity.y);

        _isGrounded = Physics2D.OverlapCircle(groundPoint.position, _overlapRadius, groundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _theRB.velocity = new Vector2(_theRB.velocity.x, jumpForce);
        }

        _playerAnim.SetBool("IsGrounded", _isGrounded);
        _playerAnim.SetFloat("Speed", Mathf.Abs(_theRB.velocity.x));
    }
}
