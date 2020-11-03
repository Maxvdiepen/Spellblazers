using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCompendium : MonoBehaviour
{
    public List<SO_Spell> allSpells;
    public List<GameObject> syllablesOnWall;
    public SO_GameEvent guessedCorrectly;

    public Image solutionPainting;
    public Text solutionText;

    [SerializeField]private SO_Spell inputSpell;

    public void CheckIfInputCorrect()
    {
        SetInputValue();
        IsInputSpellInSpellList();
    }

    public void SetInputValue()
    {
        inputSpell.syllablesInName.Clear();

        foreach (GameObject sow in syllablesOnWall)
        {
            inputSpell.syllablesInName.Add(sow.GetComponent<SyllableOnWall>().syllableValue);
        }
    }

    public void IsInputSpellInSpellList()
    {
        foreach (SO_Spell sp in allSpells)
        {
            if (DoSyllablesMatch(sp))
            {
                SetSolution(sp);
                ToggleSolution();
            }
        }
    }

    public bool DoSyllablesMatch(SO_Spell listSpell)
    {
        for (int i = 0; i < listSpell.syllablesInName.Count; i++)
        {
            if (listSpell.syllablesInName[i].syllableSpelling != inputSpell.syllablesInName[i].syllableSpelling)
            {
                return false;
            }
        }
        return true;
    }

    public void SetSolution(SO_Spell match)
    {
        solutionPainting.sprite = match.spellPicture;
        solutionText.text = match.translation;
    }

    public void ToggleSolution()
    {
        solutionPainting.enabled = !solutionPainting.enabled;
        solutionText.enabled = !solutionText.enabled;
    }
}
