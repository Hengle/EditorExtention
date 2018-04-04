using UnityEngine;
using UnityEditor;

[System.Serializable]
public class Vector3Curve
{
    public AnimationCurve xCurve = AnimationCurve.Linear(0, 0, 1, 1);
    public AnimationCurve yCurve = AnimationCurve.Linear(0, 0, 1, 1);
    public AnimationCurve zCurve = AnimationCurve.Linear(0, 0, 1, 1);
}

public class CustomVector3Drawer : PropertyDrawer
{
    public override void OnGUI(Rect pos, SerializedProperty property, GUIContent label)
    {
        if (property.serializedObject.isEditingMultipleObjects) return;

        var xCurve = property.FindPropertyRelative("xCurve");
        var yCurve = property.FindPropertyRelative("yCurve");
        var zCurve = property.FindPropertyRelative("zCurve");

        // label = EditorGUI.BeginProperty(pos, label, property);

        EditorGUI.PropertyField(new Rect(pos.width, pos.y, 0, pos.height), xCurve, GUIContent.none);
        EditorGUI.PropertyField(new Rect(pos.width, pos.y, 0, pos.height), yCurve, GUIContent.none);
        EditorGUI.PropertyField(new Rect(pos.width, pos.y, 0, pos.height), zCurve, GUIContent.none);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        if (property.serializedObject.isEditingMultipleObjects) return 0f;
        return base.GetPropertyHeight(property, label) + 16f;
    }
}

