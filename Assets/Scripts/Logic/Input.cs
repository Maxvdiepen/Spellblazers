using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    public SO_GameEvent buttonDown;
    public SO_GameEvent moveCursor;
    public SO_GameEvent submitSolution;
    public SO_GameEvent clearSolution;
    public SO_GameEvent selectPrefix;
    public SO_GameEvent selectRoot;
    public SO_GameEvent selectPUSuffix;
    public SO_GameEvent selectSuffix;

    private void OnCall()
    {
        // buttonDown.Raise();
        StartCoroutine(InputToEvent(buttonDown));
    }

    private void OnSubmit()
    {
        submitSolution.Raise();
    }

    private void OnClear()
    {
        clearSolution.Raise();
    }

    private void OnL2()
    {
        selectPrefix.Raise();
    }

    private void OnL1()
    {
        selectRoot.Raise();
    }

    private void OnR1()
    {
        selectPUSuffix.Raise();
    }

    private void OnR2()
    {
        selectSuffix.Raise();
    }
    
    public IEnumerator InputToEvent(SO_GameEvent EventToRaise)
    {
        EventToRaise.Raise();
        yield return new WaitForSeconds(10f);
    }
}
