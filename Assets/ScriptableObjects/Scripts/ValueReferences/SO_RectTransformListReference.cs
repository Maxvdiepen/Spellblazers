using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RectTransform", menuName = "ScriptableObjects/ValueReferences/RectTransformList")]
public class SO_RectTransformListReference : ScriptableObject
{
    public List<RectTransform> value;
}
