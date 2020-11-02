using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyllableOnWall : MonoBehaviour
{
    public SO_Syllable syllableValue;
    public SO_Syllable syllableCursor;

    public GameObject inputBox;
    public Text syllableText;

    public void Start()
    {
        ClearOnSetUp(); 
    }

    public void ClearOnSetUp()
    {
        syllableValue.ClearSyllableData();
    }

    public void SetSyllableOnWall()
    {
        SetSyllableValue();
        SetText();
        TurnOffInputBox();
    }

    public void SetSyllableValue()
    {
        syllableValue.MatchSyllableData(syllableCursor);
    }

    public void SetText()
    {
        syllableText.text = syllableValue.syllableSpelling;
        syllableText.enabled = true;
    }

    public void TurnOffInputBox()
    {
        inputBox.SetActive(false);
    }
}
