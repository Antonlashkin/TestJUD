using System.Collections.Generic;
using UnityEngine;

//This scriptable object containing the colors and labels of the buttons
[CreateAssetMenu(fileName = "Colors", menuName = "UI/Colors")]
public class ListOfColorScriptableObject : ScriptableObject
{
    public List<Color> colorsOfObject;
    public List<string> buttonsName;
}
