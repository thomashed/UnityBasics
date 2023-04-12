using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Spinable : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0,rotationSpeed,0);
        
        
        
    }
}
