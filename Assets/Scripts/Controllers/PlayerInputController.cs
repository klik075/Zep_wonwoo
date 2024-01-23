using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController //사용자 입력에 따라 대리자에게 값을 넘겨줌
{
    private Camera _camera;
    private void Awake() 
    {
        _camera = Camera.main; //씬에 존재하는 메인 tag를 가진 카메라를 가져옴
    }
    // Start is called before the first frame update
    public void OnMove(InputValue value)
    {
        
        Vector2 moveInput = value.Get<Vector2>().normalized; //이동키를 입력하면 입력에 해당하는 값을 길이가 1인 벡터로 받아와서
        CallMoveEvent(moveInput);// 무브이벤트에 벡터를 넣는다.
    }
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();//스크린 좌표
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim); //스크린 좌표를 월드 좌표로 변환한다.
        newAim = (worldPos -(Vector2)transform.position).normalized;
        if(newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }
    public void OnFire(InputValue value)
    {
        Debug.Log("공격"+ value.ToString());
    }
    public void OnSlide()
    {
        CallSlideEvent();
    }

}
