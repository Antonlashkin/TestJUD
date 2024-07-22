using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//This class changes the name of the button when initialized
public class ChangeNameOfButton : MonoBehaviour
{
    [SerializeField] private ListOfColorScriptableObject colorsOfObject;
    [SerializeField] private TMP_Text nameOfButton;
    [SerializeField] private int indexOfName;
    
    //Changes the name of the button when initialized
    void Start()
    {
        //When we go beyond the list, we throw an exception
        if (indexOfName >= colorsOfObject.buttonsName.Count || indexOfName < 0)
        {
            Debug.LogError("IndexOutOfBounds");
            return;
        }

        //Сhange the button label
        nameOfButton.text = colorsOfObject.buttonsName[indexOfName];
    }
}
