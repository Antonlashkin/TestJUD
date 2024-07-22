using System;
using UnityEngine;

//This is a class for handling the button click event
public class ButtonClick : MonoBehaviour
{
    [SerializeField] private ListOfColorScriptableObject colorsOfObject;

    public static event Action<Color> OnColorChanged;

    //This function is executed when you click on the color change button
    public void OnButtonClick(int indexOfColor)
    {
        //When we go beyond the list, we throw an exception
        if (indexOfColor >= colorsOfObject.colorsOfObject.Count || indexOfColor < 0)
        {
            Debug.LogError("IndexOutOfBounds");
            return;
        }
        
        //Call the event
        OnColorChanged?.Invoke(colorsOfObject.colorsOfObject[indexOfColor]);
    }
}
