using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateInventoryOutside : MonoBehaviour
{
    public GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(inventory, new Vector3(0,0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
