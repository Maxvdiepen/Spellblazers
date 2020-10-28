using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCompendium : MonoBehaviour
{
    public List<SO_Spell> allSpells;
    public List<GameObject> syllablesOnWall;
    public SO_GameEvent guessedCorrectly;

    [SerializeField]private SO_Spell inputSpell;

    public void CheckIfSpellCorrect()
    {
        inputSpell.syllablesInName.Clear();
        
        foreach(GameObject sow in syllablesOnWall)
        {
            inputSpell.syllablesInName.Add(sow.GetComponent<SyllableOnWall>().syllable);
        }

        foreach(SO_Spell sp in allSpells)
        {
            if (inputSpell == sp)
            {
                guessedCorrectly.Raise();
            }
        }
    }
}
