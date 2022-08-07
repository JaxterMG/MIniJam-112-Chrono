using System;
using TMPro;
using UnityEngine;
using DG.Tweening;

public class DreamRoom : Room
{
    private int counter = 0;
    public TextMeshPro[] Texts;
    public BoxCollider2D[] Colliders;

    private void Start()
    {
        foreach (var text in Texts)
        {
            text.DOFade(0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (counter != 0 && counter != Texts.Length)
        {
            Texts[counter - 1].DOFade(0, 1);
        }

        Texts[counter].DOFade(1, 2);
        Colliders[counter].enabled = false;

        counter++;
    }

}