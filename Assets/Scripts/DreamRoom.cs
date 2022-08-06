using TMPro;
using UnityEngine;
using DG.Tweening;

public class DreamRoom : Room
{
    private int counter = 0;
    public TextMeshPro[] Texts;
    public BoxCollider2D[] Colliders;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Texts[counter].DOFade(0,1);
        Colliders[counter].enabled = false;
        counter++;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
       
    }
}