using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(CustomVector3CurveAttribute))]
public class CustomVector3Drawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.serializedObject.isEditingMultipleObjects) return;

        var xCurve = property.FindPropertyRelative("xCurve");
        var yCurve = property.FindPropertyRelative("yCurve");
        var zCurve = property.FindPropertyRelative("zCurve");
        EditorGUILayout.CurveField("Animation on X", xCurve.animationCurveValue);
        EditorGUILayout.CurveField("Animation on Y", yCurve.animationCurveValue);
        EditorGUILayout.CurveField("Animation on Z", zCurve.animationCurveValue);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        if (property.serializedObject.isEditingMultipleObjects) return 0f;
        return base.GetPropertyHeight(property, label) + 16f;
    }
}
