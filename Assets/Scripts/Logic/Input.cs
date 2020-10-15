using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    public SO_GameEvent buttonDown;

    private void OnCall()
    {
        buttonDown.Raise();
    }
}
