using System.Collections;
using DG.Tweening;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Transform point;
    private Animator _animator;
    public float Delay = 1;
    public bool AutoInvoke = false;
    private void Start()
    {
        if (AutoInvoke)
        {
            Invoke("TriggerCat", 0);
        }
        _animator = GetComponent<Animator>();
    }

    public void TriggerCat()
    {
        StartCoroutine(WalkWithDelay());
    
    }

    IEnumerator WalkWithDelay()
    {
        yield return new WaitForSeconds(Delay);
        _animator.Play("CatWalk");
       var ePostEvent = AkSoundEngine.PostEvent("Cat", gameObject);
        transform.DOMoveX( point.position.x, 10).OnComplete(delegate
        {
            AkSoundEngine.StopPlayingID(ePostEvent);
            _animator.Play("CatIdle");
        });
    }
    
}
