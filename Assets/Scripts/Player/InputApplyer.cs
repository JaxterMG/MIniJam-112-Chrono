using UnityEngine;
using UnityEngine.InputSystem;

public class InputApplyer
{
    private Interactor _playerInteractor;

    private PlayerActions _playerActions;

    private Vector2 _horizontalInput;
    public bool IsMovementPressed;

    public void Initialize(Interactor interactor)
    {
        _playerInteractor = interactor;

        _playerActions = new PlayerActions();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        _playerActions.PlayerWalk.Walk.performed += context => _horizontalInput = context.ReadValue<Vector2>();
        _playerActions.PlayerWalk.Walk.started += PlayerWalkPressed;
        _playerActions.PlayerWalk.Walk.canceled += PlayerWalkReleased;
        _playerActions.PlayerWalk.Interact.performed += context => _playerInteractor.Interact(context);
        _playerActions.Enable();
    }

    private void PlayerWalkPressed(InputAction.CallbackContext obj)
    {
        IsMovementPressed = true;
    }

    private void PlayerWalkReleased(InputAction.CallbackContext obj)
    {
        IsMovementPressed = false;
    }

    public Vector2 GetHorizontalInput()
    {
        return _horizontalInput;
    }


    private void OnEnable()
    {
        _playerActions.Enable();
    }

    private void OnDisable()
    {
        _playerActions.Disable();
    }
}