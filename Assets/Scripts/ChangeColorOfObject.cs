using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOfObject : MonoBehaviour
{
    [SerializeField] private Renderer mutableObjectRender;
    [SerializeField] private List<Color> colorsOfObject;
    
    private Color currentColor;
    

    public void ChangeCurrentColor(int newColorId)
    {
        currentColor = colorsOfObject[newColorId];
        VisualizationChanges();
    }

    private void VisualizationChanges()
    {
        mutableObjectRender.material.SetColor("_Color", currentColor);
    }
}
