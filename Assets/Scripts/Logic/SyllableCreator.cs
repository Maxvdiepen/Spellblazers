using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyllableCreator : MonoBehaviour
{
    public List<SO_Syllable> allAvailableSyllables;
    public GameObject slotPrefab;

    void Start()
    {
        for (int i = 0; i < allAvailableSyllables.Count; i++)
        {
            GameObject syllableSlot = Instantiate(slotPrefab, transform);
            syllableSlot.GetComponentInChildren<Text>().text = allAvailableSyllables[i].syllable;
        }
    }
}
