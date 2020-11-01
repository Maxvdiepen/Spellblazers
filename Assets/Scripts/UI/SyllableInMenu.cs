using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SyllableInMenu : Selectable, ISelectHandler, IDeselectHandler
{
    public SO_Syllable syllable;
    public SO_Syllable cursorSyllable;
    public Image syllableBG;
    public Text syllableText;

    public void OnSelect(BaseEventData eventData)
    {
        cursorSyllable.syllableSpelling = syllable.syllableSpelling;
        cursorSyllable.pronunciation = syllable.pronunciation;
        syllableBG.color = colors.selectedColor;
    }

    public void OnDeselect(BaseEventData eventData)
    {
        syllableBG.color = colors.normalColor;
    }
}
