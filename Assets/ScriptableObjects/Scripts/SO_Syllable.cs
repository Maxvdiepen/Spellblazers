using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Syllable", menuName = "ScriptableObjects/Linguistics/Syllable")]
public class SO_Syllable : ScriptableObject
{
    public string syllable;
    public AudioClip pronunciation;
}
