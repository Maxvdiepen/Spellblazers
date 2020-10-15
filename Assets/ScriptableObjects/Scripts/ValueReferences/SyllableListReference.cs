using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SyllableList", menuName = "ScriptableObjects/ValueReferences/SyllableList")]
public class SyllableListReference : ScriptableObject
{
    public List<SO_Syllable> value;
}
