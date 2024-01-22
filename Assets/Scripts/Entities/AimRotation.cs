using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer CharacterRenderer;
    private CharacterController _cotroller;
    private void Awake() 
    {
        _cotroller = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _cotroller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        Rotate(newAimDirection);
    }

    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;// 벡터의 각도를 구한다.
        CharacterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
