using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainCoat : MonoBehaviour
{
    public GameObject player;

    public KeyCode interactKey;
    bool collide;
    private void OnTriggerEnter2D(Collider2D other)
    {
        collide = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        collide = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (collide == true && Input.GetKeyDown(interactKey))
        {
            Console.WriteLine("Hello, Ms. Lawrence, I am here for my coat.");
            GameManager.Instance.hasCoat = true;
            GameManager.Instance.DET++;
        }
    }
}


