using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0f, Input.GetAxis("Mouse X") * sensitivityHor, 0f);
        }
        else if (axes == RotationAxes.MouseY)
        {
            
        }
        else
        {
            // both axes
        }
    }
    
    
    
}
