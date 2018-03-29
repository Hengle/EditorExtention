using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeTester : MonoBehaviour
{
    [CustomRange(1, 10)] public float range;
    [CustomMinMax(1, 10)] public MinMaxPair rangeMinMax;
    [CustomVector3Curve] public Vector3Curve vector3Curve;
}
