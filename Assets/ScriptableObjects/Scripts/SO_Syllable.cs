using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Syllable", menuName = "ScriptableObjects/Linguistics/Syllable")]
public class SO_Syllable : ScriptableObject
{
    public string syllableSpelling;
    public AudioClip pronunciation;
    public Color32 typeColor;
    public Color32 colorToSet;

    public void SetCorrectColor()
    {
        colorToSet = typeColor;
    }
}
