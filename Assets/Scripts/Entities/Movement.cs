using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private Vector2 _movementDirection = Vector2.zero; 
    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>(); //PlayerInputController를 가져온다.
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    private void Start()
    {
        _controller.OnMoveEvent += Move; //구독을 한다.
    }
    private void FixedUpdate() 
    {
        ApplyMovement(_movementDirection);
    }
    private void Move(Vector2 direction) //자신의 움직일 방향을 설정한다.
    {
        _movementDirection = direction;
    }
    private void ApplyMovement(Vector2 direction)//방향으로 현재의 속도를 나타낸다.
    {
        direction = direction * 7;
        _rigidbody.velocity = direction;
    }
    // Update is called once per frame
}
