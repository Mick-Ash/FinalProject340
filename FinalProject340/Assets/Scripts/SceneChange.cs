using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject player;
    public KeyCode changeSceneKey;
    bool collide;
    //public GameObject storeDoor;
    // need to make it known that you need to collide with object tagged Store Door to change scene
    
    private void OnTriggerEnter2D(Collider2D other)
     {
        
        { 
            collide = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    
        {
            collide = false;
        
    }

    void Update()
    {
        if (collide == true && Input.GetKeyDown(changeSceneKey))
        {
            if (GameManager.Instance.hasCoat == false)
            {
                player = GameObject.FindGameObjectWithTag("Player");
                SceneManager.LoadScene(3);
            }
        }
    }
}
