using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // private static GameManager instance;
    public static GameManager Instance;



    public bool hasCoat { get; set; } = false;

    public int DET { get; set; }



    void Awake()

    {

        if (Instance == null)

        {

            Instance = this;

        }

    }
}
