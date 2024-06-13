using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private PlayerController _player;

    private void Awake()
    {
        _player = FindAnyObjectByType<PlayerController>();
    }

    void Update()
    {
        if (_player != null)
        {
            transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, transform.position.z);
        }
    }
}
