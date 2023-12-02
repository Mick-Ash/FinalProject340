using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class OutsideDialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
        [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;
    private TypeWriterEffect typewriterEffect;
    public bool IsOpen { get; private set; }

    public void Start()
    {
        typewriterEffect = GetComponent<TypeWriterEffect>();
        CloseDialoguePanel();
        ShowDialogue(testDialogue);
    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        IsOpen = true;
        dialoguePanel.SetActive(true);
        StartCoroutine(StepThroughDialogue(dialogueObject));
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        foreach (string dialogue in dialogueObject.Dialogue)
        {
            yield return typewriterEffect.Run(dialogue, textLabel);
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        }

        CloseDialoguePanel();
    }

    private void CloseDialoguePanel()
    {
        IsOpen = false;
        dialoguePanel.SetActive(false);
        textLabel.text = string.Empty;
    }
}
