using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Spell", menuName = "ScriptableObjects/Linguistics/Spell")]
public class SO_Spell : ScriptableObject
{
    public List<SO_Syllable> syllablesInName;
    public AudioClip pronunciation;
    public Image spellPicture;
}
