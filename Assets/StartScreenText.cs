using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class StartScreenText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] string _dialogueTexts;
    [SerializeField] private float _delay = 0.1f;

    private void Awake()
    {
        StartCoroutine(WaitDialog());
    }

    IEnumerator WaitDialog()
    {
        _text.text = "";
        yield return new WaitForSeconds(1);
        for (int i = 0; i < _dialogueTexts.Length; i++)
        {
            _text.text += _dialogueTexts[i];
            // SoundManager.Instance.PlayWhisperSound();
            yield return new WaitForSeconds(_delay);
        }


        yield return new WaitForSeconds(2);
        _text.text = "";
        EndText();
    }


    private void EndText()
    {
        ScreenDarkening.Instance.DisableDarkScreen();
    }
}
