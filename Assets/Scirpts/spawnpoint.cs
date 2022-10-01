using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{
    public GameObject[] spawnObj;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnObj[Random.Range(0, spawnObj.Length)], this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
