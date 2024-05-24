using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balazos : MonoBehaviour
{
    public GameObject DisparoPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump")) 
        {
            Instantiate(DisparoPrefab, transform.position, Quaternion.identity);
        }
    }
}