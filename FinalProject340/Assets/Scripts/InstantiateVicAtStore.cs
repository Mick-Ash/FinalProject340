using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateVicAtStore : MonoBehaviour
{
    public GameObject playerprefab;
    void Start()
    {
        Instantiate(playerprefab, new Vector3 (0, -3, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
