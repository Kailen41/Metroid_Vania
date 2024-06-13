using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private PlayerController _player;

    public BoxCollider2D boundsBox;

    private float _halfHeight, _halfWidth;

    private void Awake()
    {
        _player = FindAnyObjectByType<PlayerController>();

        _halfHeight = Camera.main.orthographicSize;
        _halfWidth = _halfHeight * Camera.main.aspect;
    }

    void Update()
    {
        if (_player != null)
        {
            transform.position = new Vector3(
                Mathf.Clamp(_player.transform.position.x, boundsBox.bounds.min.x + _halfWidth, boundsBox.bounds.max.x - _halfWidth),
                Mathf.Clamp(_player.transform.position.y, boundsBox.bounds.min.y + _halfHeight, boundsBox.bounds.max.y - _halfHeight), 
                transform.position.z);
        }
    }
}
