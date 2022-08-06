using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement _movement;
    private InputApplyer _inputApplyer;
    private Interactor _interactor;
    public Animator UiAnimator;
    public Camera Camera;
    

    private void Start()
    {
        if (_movement == null)
        {
            InitializeMovement();
        }

        if (_interactor == null)
        {
            InitializeInteractor();
        }

        if (_inputApplyer == null)
        {
            InitializeInputApplyer();
        }
    }

    private void FixedUpdate()
    {
        if (_inputApplyer.IsMovementPressed)
        {
            _movement.Move(_inputApplyer.GetHorizontalInput());
        }
    }

    private void InitializeMovement()
    {
        _movement = new Movement(2, GetComponent<Rigidbody2D>());
    }

    private void InitializeInteractor()
    {
        _interactor = new Interactor();
    }

    private void InitializeInputApplyer()
    {
        _inputApplyer = new InputApplyer();
        _inputApplyer.Initialize(_interactor);
    }

    public void SetInteractable(Interactable interactor)
    {
        _interactor.SetInteractable(interactor);
    }

    public void PreparePlayerUI()
    {
        UiAnimator.Play("InteractionButtonAppear");
    }
    public void HidePlayerUI()
    {
        UiAnimator.Play("InteractionButtonDisappear");
    }
}