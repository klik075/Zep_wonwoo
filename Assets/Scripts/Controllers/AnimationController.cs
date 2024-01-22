using UnityEngine;

public class AnimationController : Animations
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private static readonly int IsSliding = Animator.StringToHash("IsSliding");

    protected override void Awake()
    {
        base.Awake();
    }
    void Start()
    {
        controller.OnMoveEvent += Move;
        // controller.OnSlideEvent += Sliding;
    }

    // private void Sliding()
    // {
    //     animator.SetTrigger(IsSliding);

    // }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking,obj.magnitude >0.5f); //벡터의 크기가 0.5보다 크면 true
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
