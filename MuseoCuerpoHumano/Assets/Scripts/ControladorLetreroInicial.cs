using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ControladorLetreroInicial : MonoBehaviour
{
  
    void Update()
    {
        Debug.Log("Esto está pasando");
        if (Keyboard.current.anyKey.wasPressedThisFrame
            || Mouse.current.leftButton.wasPressedThisFrame
            || Mouse.current.rightButton.wasPressedThisFrame
            || Mouse.current.middleButton.wasPressedThisFrame
           )
        {
            
            gameObject.SetActive(false);
        }
    }
}
