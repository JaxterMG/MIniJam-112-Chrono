
using System.Collections;
using DG.Tweening;
using UnityEngine;

public class MusicChange : MonoBehaviour
{
    public AkAmbient Ambient;
    public float Delay;

    public void ChangeMusic()
    {
        Ambient.Stop(1);
        StartCoroutine(StartWithDelay());

    }

    IEnumerator StartWithDelay()
    {
        yield return new WaitForSeconds(Delay);
        AkSoundEngine.PostEvent("Good_Night_Cat", gameObject);
    }
}
