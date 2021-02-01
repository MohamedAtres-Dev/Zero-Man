using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    // Gameplay
    public event UnityAction jumpEvent = delegate { };
    public event UnityAction slideEvent = delegate { };
    public event UnityAction doubleJumpEvent = delegate { };
    public event UnityAction jumpCanceledEvent = delegate { };
    public event UnityAction pauseEvent = delegate { };
    public event UnityAction moveLeftEvent = delegate { };
    public event UnityAction moveRightEvent = delegate { };

    //public event UnityAction<Vector2> moveEvent = delegate { };
    public void OnMoveLeft(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            moveLeftEvent.Invoke();
    }

    public void OnMoveRight(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            moveRightEvent.Invoke();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            Debug.Log("Move Jump");
    }

    public void OnSlide(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            Debug.Log("Move Slide");
    }

    public void OnDoubleJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            Debug.Log("Double Jump");
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            Debug.Log("Move Dash");
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            pauseEvent.Invoke();
    }


}
