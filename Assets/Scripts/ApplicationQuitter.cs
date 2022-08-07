using UnityEngine;

public class ApplicationQuitter : Interactable
{
    public Transform Player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent<PlayerController>(out var controller))
        {
            controller.SetInteractable(this);
            Player = controller.transform;
            controller.PreparePlayerUI();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Player = null;
        if (other.TryGetComponent<PlayerController>(out var controller))
        {
            controller.SetInteractable(null);
            controller.HidePlayerUI();
        }
    }

    public override void OnInteract()
    {
        Application.Quit();
    }
    
}