using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class RoomTransfer : Interactable
{
    public Transform Player;
    public RoomTransfer Connection;
    [Header("Enter")] public bool IsLeft;

    [Header("TransferPoints")] public Transform _firstPoint;
    public Transform _secondPoint;
    public float Radius = 0.4f;

    public UnityEvent OnInteact;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (Connection)
        {
            if (col.TryGetComponent<PlayerController>(out var controller))
            {
                controller.SetInteractable(this);
                Player = controller.transform;
                controller.PreparePlayerUI();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (Connection)
        {
            Player = null;
            if (other.TryGetComponent<PlayerController>(out var controller))
            {
                controller.SetInteractable(null);
                controller.HidePlayerUI();
            }
        }
    }

    public override void OnInteract()
    {
        OnInteact?.Invoke();
        PlaySound();
        ScreenDarkening.Instance.EnableDarkScreen();
        StartCoroutine(Transfer());
    }

    public void PlaySound()
    {
        AkSoundEngine.PostEvent("Door", this.gameObject);
    }
   

    public IEnumerator Transfer()
    {
        yield return new WaitForSeconds(1);
        Player.transform.position = IsLeft ? Connection._secondPoint.position : Connection._firstPoint.position;
        Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, 1);
        Camera.main.transform.position = Connection.GetComponentInParent<Room>().CameraPoint.position;
    }

    
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        var drawEnter = IsLeft ? _firstPoint.position : _secondPoint.position;
        Gizmos.DrawWireSphere(drawEnter, Radius);
        if (Connection != null)
        {
            var start = IsLeft ? _firstPoint.position : _secondPoint.position;
            var end = Connection.IsLeft ? Connection._firstPoint.position : Connection._secondPoint.position;
            Gizmos.DrawLine(start, end);
        }
    }
}
