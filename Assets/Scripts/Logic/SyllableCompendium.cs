using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyllableCompendium : MonoBehaviour
{
    public List<GameObject> syllablesInMenu;

    public List<RectTransform> menuPositions;
    public SyllableListReference menuValues;

    public void Awake()
    {
        menuPositions.Clear();
        menuValues.value.Clear();

        foreach(GameObject go in syllablesInMenu)
        {
            menuPositions.Add(go.GetComponent<RectTransform>());
            menuValues.value.Add(go.GetComponent<SyllableInMenu>().syllable);
        }
    }
}
