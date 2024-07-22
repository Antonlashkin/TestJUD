using System;
using System.Collections.Generic;
using UnityEngine;

//This class changes the color of the cube
public class ChangeColorOfObject : MonoBehaviour
{
    [SerializeField] private Renderer mutableObjectRender;
    
    //Function of changing color
    public void ChangeColorOfObjectMethod(Color currentColor)
    {
        mutableObjectRender.material.SetColor("_Color", currentColor);
    }

    //Event subscription
    private void OnEnable()
    {
        ButtonClick.OnColorChanged += ChangeColorOfObjectMethod;
    }
    
    //unsubscribe from event
    private void OnDisable()
    {
        ButtonClick.OnColorChanged -= ChangeColorOfObjectMethod;
    }
}
