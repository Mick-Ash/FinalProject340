using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    [SerializeField] OutsideDialogueUI dialogueUI;

    public Rigidbody2D rb;
    public OutsideDialogueUI DialogueUI => dialogueUI;

    public Interactable Interactable { get; set; }
    Vector2 movement;

   public Animator animator;


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Interactable != null)
            {
                Interactable.Interact(this);
            }
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);   
    }
}
