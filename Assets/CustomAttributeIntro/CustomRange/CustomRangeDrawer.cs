using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(CustomRangeAttribute))]
public class CustomRangeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        CustomRangeAttribute rangAttr = (CustomRangeAttribute)attribute;

        if(property.propertyType == SerializedPropertyType.Float)
        {
            EditorGUI.Slider(position, property, rangAttr.min, rangAttr.max, label);
        }
    }
}
