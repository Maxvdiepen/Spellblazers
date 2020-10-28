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
        buttonDown.Raise();
    }

    private void OnNavigate()
    {
        moveCursor.Raise();
    }

    private void OnSubmit()
    {
        submitSolution.Raise();
    }

    private void OnClear()
    {
        clearSolution.Raise();
    }

    private void OnL1()
    {
        selectPrefix.Raise();
    }

    private void OnL2()
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
}
