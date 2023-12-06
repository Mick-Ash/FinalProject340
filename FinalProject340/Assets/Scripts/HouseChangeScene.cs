using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseChangeScene : MonoBehaviour
{
    
    public GameObject player;
    public KeyCode changeSceneKey;
    bool collide;
    // public GameObject houseDoor;
    // need to specify that hasCoat needs to be true and need to collide with object tagged House Door to change to house scene
    

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
        if (collide == true && Input.GetKeyDown(changeSceneKey))
        {
            if (GameManager.Instance.hasCoat == true)
            {
                player = GameObject.FindGameObjectWithTag("Player");
                SceneManager.LoadScene(2);
            }
        }
    }
}
