using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFunctions : MonoBehaviour
{
    public void ToggleVisibility()
    {
        this.GetComponent<Text>().enabled =! this.GetComponent<Text>().enabled;
    }
}