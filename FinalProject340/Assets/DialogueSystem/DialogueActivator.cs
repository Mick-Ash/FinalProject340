using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour, Interactable
{
    [SerializeField] private DialogueObject dialogueObject;
    public void Interact (PlayerMovement player)
    {
        player.DialogueUI.ShowDialogue(dialogueObject);
    }
}
