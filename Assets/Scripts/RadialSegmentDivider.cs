using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialSegme : MonoBehaviour
{
    public IntReference amountOfSpells;
    public IntReference fov;

    private float result;

    public void CalculateRadialSegments()
    {
        result = fov.value / amountOfSpells.value;
    }
}
