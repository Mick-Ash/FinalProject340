using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveStoreScript : MonoBehaviour
{
    public GameObject player;
    public KeyCode changeSceneKey;
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
