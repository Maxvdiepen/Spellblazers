using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyllableOnWall : MonoBehaviour
{
    public SO_Syllable syllable;

    public void SetText()
    {
        this.GetComponentInChildren<Text>().text = syllable.syllableSpelling;
    }
}
