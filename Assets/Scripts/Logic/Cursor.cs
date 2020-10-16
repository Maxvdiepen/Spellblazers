using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Cursor : MonoBehaviour
{
    public GameObject syllableCompendium;
    public List<RectTransform> syllablePositions;
    public SyllableListReference syllableValues;
    
    public SO_Syllable cursorData;

    private int positionCounter;

    private void Start()
    {
        positionCounter = 5;
        syllablePositions = syllableCompendium.GetComponent<SyllableCompendium>().menuPositions;
        MoveCursor();
    }

    public void MoveCursor()
    {
        this.GetComponent<RectTransform>().localPosition = syllablePositions[positionCounter].localPosition;
        cursorData = syllableValues.value[positionCounter];
        //Debug.Log(cursorPos);
    }

    //private void OnNavigate(InputValue value)
    //{
    //    if (_ready.value == false)
    //    {
    //        StartCoroutine(MovePlayerPick(value.Get<Vector2>()));
    //    }
    //}
}
