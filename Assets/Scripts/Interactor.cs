using UnityEngine;
using UnityEngine.InputSystem;

public  class Interactor
{
     private Interactable _interactable;
    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed && _interactable)
        {
            _interactable.OnInteract();
        }

    }

    public void SetInteractable(Interactable interactable)
    {
        _interactable = interactable;
    }
}