using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateVicOutside : MonoBehaviour
{
    public GameObject playerPrefab;

    private void Start()
    {
        if (GameManager.Instance.hasCoat == false)
        {
            Instantiate(playerPrefab, new Vector3(9, 3, 0), Quaternion.identity);
        }
        else { Instantiate(playerPrefab, new Vector3(12, 5, 0), Quaternion.identity); }
    }
    
}
