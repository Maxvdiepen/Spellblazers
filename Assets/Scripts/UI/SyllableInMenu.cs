using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyllableInMenu : MonoBehaviour
{
    public SO_Syllable syllable;

    public void SetTextColor()
    {
        this.GetComponentInChildren<Text>().color = syllable.colorToSet;
    }
}
