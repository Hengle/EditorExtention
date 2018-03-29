using UnityEngine;
using System;

public class CustomMinMaxAttribute : PropertyAttribute
{
    public float Min, Max;

    public CustomMinMaxAttribute(float min, float max)
    {
        Min = min;
        Max = max;
    }
}

[Serializable]
public struct MinMaxPair
{
    public float Min, Max;
    
    public MinMaxPair(float min, float max)
    {
        Min = min;
        Max = max;
    }
}

