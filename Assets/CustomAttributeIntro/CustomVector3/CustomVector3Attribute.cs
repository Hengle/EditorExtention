using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CustomVector3CurveAttribute : PropertyAttribute
{
}

[Serializable]
public struct Vector3Curve
{
    public AnimationCurve xCurve;
    public AnimationCurve yCurve;
    public AnimationCurve zCurve;

    public Vector3Curve(AnimationCurve x, AnimationCurve y, AnimationCurve z)
    {
        xCurve = x;
        yCurve = y;
        zCurve = z;
    }
}
