using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dog_Controller : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        var gamepad = Gamepad.current;
        Vector2 moveInput = gamepad.leftStick.ReadValue();
        
    }
}
