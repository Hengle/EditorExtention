using UnityEngine;
using UnityEditor;

public class CustomRangeAttribute : PropertyAttribute
{

    public float min;
    public float max;

    public CustomRangeAttribute(float min, float max)
    {
        this.min = min;
        this.max = max;
    }
}

[CustomPropertyDrawer(typeof(CustomRangeAttribute))]
public class CustomRangeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        CustomRangeAttribute rangAttr = (CustomRangeAttribute)attribute;

        if (property.propertyType == SerializedPropertyType.Float)
        {
            EditorGUI.Slider(position, property, rangAttr.min, rangAttr.max, label);
        }
    }
}

