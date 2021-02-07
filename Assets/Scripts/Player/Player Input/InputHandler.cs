using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using System;


[CreateAssetMenu(fileName ="Input" , menuName ="InputHandler")]
public class InputHandler : ScriptableObject , GameInput.IGamePlayActions 
{
    // Gameplay
    public event UnityAction jumpEvent = delegate { };
    public event UnityAction slideEvent = delegate { };
    public event UnityAction doubleJumpEvent = delegate { };
    public event UnityAction jumpCanceledEvent = delegate { };
    public event UnityAction pauseEvent = delegate { };
    public event UnityAction moveLeftEvent = delegate { };
    public event UnityAction moveRightEvent = delegate { };
    public event UnityAction dashEvent = delegate { };

    private GameInput gameInput;

    private void OnEnable()
    {
        if (gameInput == null)
        {
            
            gameInput = new GameInput();
            gameInput.GamePlay.SetCallbacks(this);
            
        }

        gameInput.GamePlay.Enable();
    }

    private void OnDisable()
    {
        gameInput.GamePlay.Disable();
    }

    
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

    public void OnDouble_Jump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            Debug.Log("Double Jump");
    }
}
