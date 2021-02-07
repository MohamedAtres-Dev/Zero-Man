using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerController))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler = default;

    [NonSerialized] public PlayerController _playerController = default;
    [NonSerialized] public CharacterController _characterController = default;
    [NonSerialized] public Animator _animator = default;

    #region General Variables
    private const int LANE_LENGTH = 3;
    [NonSerialized] public LanePosition currentLane;
    private Vector3 direction;
    private int runHash = Animator.StringToHash("AnimationPar");
    #endregion



    #region Movement Variables
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float jumpSpeed = 20f;
    [SerializeField] private float gravity = -9.81f;

    
    #endregion

    #region InputVariables
    [NonSerialized] public bool isMoveLeft = false;
    [NonSerialized] public bool isMoveRight = false;
    [NonSerialized] public bool isJump = false;
    [NonSerialized] public bool isDoubleJump = false;
    [NonSerialized] public bool isSlide = false;
    [NonSerialized] public bool isDash = false;
    #endregion

    private void OnEnable()
    {
        _inputHandler.doubleJumpEvent += _inputHandler_doubleJumpEvent;
        _inputHandler.jumpEvent += _inputHandler_jumpEvent;
        _inputHandler.moveLeftEvent += _inputHandler_moveLeftEvent;
        _inputHandler.moveRightEvent += _inputHandler_moveRightEvent;
        _inputHandler.slideEvent += _inputHandler_slideEvent;
        _inputHandler.dashEvent += _inputHandler_dashEvent;
    }


    private void OnDisable()
    {
        _inputHandler.doubleJumpEvent -= _inputHandler_doubleJumpEvent;
        _inputHandler.jumpEvent -= _inputHandler_jumpEvent;
        _inputHandler.moveLeftEvent -= _inputHandler_moveLeftEvent;
        _inputHandler.moveRightEvent -= _inputHandler_moveRightEvent;
        _inputHandler.slideEvent -= _inputHandler_slideEvent;
        _inputHandler.dashEvent -= _inputHandler_dashEvent;
    }

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        currentLane = LanePosition.Middle;
        _animator.SetInteger(runHash, 1);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CharacterMovement();
    }

    private void CharacterMovement()
    { 
        transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
    }

    #region Handle Input Events
    private void _inputHandler_dashEvent()
    {
        isDash = true;
    }

    private void _inputHandler_slideEvent()
    {
        isSlide = true;
    }

    private void _inputHandler_moveRightEvent()
    {
        isMoveRight = true;
    }

    private void _inputHandler_moveLeftEvent()
    {
        isMoveLeft = true;
    }

    private void _inputHandler_jumpEvent()
    {
        isJump = true;
    }

    private void _inputHandler_doubleJumpEvent()
    {
        isDoubleJump = true;
    }

    #endregion

}

public enum LanePosition
{
    Middle,
    Left,
    Right
}
