using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeWriterEffect : MonoBehaviour
{
    [SerializeField] private float typewriterSpeed = 4f;
    public Coroutine Run(string textType, TMP_Text textLabel)
    {
        return StartCoroutine(typeText(textType, textLabel));
    }

    private IEnumerator typeText(string textType, TMP_Text textLabel)
    {
        textLabel.text = string.Empty;
        float t = 0;
        int charIndex = 0;

        while (charIndex < textType.Length)
        {
            
            t += Time.deltaTime * typewriterSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textType.Length);

            textLabel.text = textType.Substring(0, charIndex);
            yield return null;
        }
        textLabel.text = textType;
    }
}
