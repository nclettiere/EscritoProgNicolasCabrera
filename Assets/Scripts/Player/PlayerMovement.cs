using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Vector2 _jumpForce = new Vector2(0, 10);
    [SerializeField] float _speed = 40f;
    [SerializeField] private Rigidbody2D _rBody;
    private float direction;

    internal void Jump()
    {
        _rBody.AddForce(_jumpForce, ForceMode2D.Impulse);
    }


    internal void Move(float direction)
    {
        this.direction = direction;
    }

    // Update is called once per frame
    void Update()
    {
        _rBody.velocity = new Vector2((direction * _speed) * Time.deltaTime, _rBody.velocity.y);
    }
}
