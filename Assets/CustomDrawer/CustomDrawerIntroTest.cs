using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomDrawerIntroTest : MonoBehaviour
{
    [ReadOnly] [SerializeField] float editorReadOnly;
    [CustomRange(1, 10)] public float range;
    [CustomMinMax(1, 10)] public MinMaxPair rangeMinMax;
    public ScaledCurve scaledCurveTest;
    public Vector3Curve vector3CurveTest;

}
