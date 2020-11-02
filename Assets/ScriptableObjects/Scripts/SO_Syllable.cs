using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Syllable", menuName = "ScriptableObjects/Linguistics/Syllable")]
public class SO_Syllable : ScriptableObject
{
    public string syllableSpelling;
    public AudioClip pronunciation;

    public void MatchSyllableData(SO_Syllable SyllableToMatch)
    {
        syllableSpelling = SyllableToMatch.syllableSpelling;
        pronunciation = SyllableToMatch.pronunciation;
    }

    public void ClearSyllableData()
    {
        syllableSpelling = null;
        pronunciation = null;
    }
}
