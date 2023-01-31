using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("Awake called.");
    }

    
    void Awake()
    {
        Debug.Log("Start called.");
    }
}
