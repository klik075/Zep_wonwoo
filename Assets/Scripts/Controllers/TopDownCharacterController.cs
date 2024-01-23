using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public event Action OnSlideEvent;
    public event Action<Vector2> OnMoveEvent; 
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction) 
    {
        OnMoveEvent?.Invoke(direction); //움직일 때 들어온 벡터를 무브 대리자에 들어있는 함수들에 매개변수로 넣어서 실행한다. 
    }
    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
    public void CallSlideEvent()
    {
        OnSlideEvent?.Invoke();
    }
}
