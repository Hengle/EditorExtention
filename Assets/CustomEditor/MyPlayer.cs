using UnityEditor;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    public int armor = 75;
    public int damage = 25;
    public GameObject gun;
}

[CustomEditor(typeof(MyPlayer))]
[CanEditMultipleObjects]
public class MyPlayerEditor : Editor
{
    SerializedProperty damageProp;
    SerializedProperty armorProp;
    SerializedProperty gunProp;

    void OnEnable()
    {
        damageProp = serializedObject.FindProperty("damage");
        armorProp = serializedObject.FindProperty("armor");
        gunProp = serializedObject.FindProperty("gun");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.IntSlider(damageProp, 0, 100, new GUIContent("Damage"));

        if (!damageProp.hasMultipleDifferentValues)
            ProgressBar(damageProp.intValue / 100.0f, "Damage");

        EditorGUILayout.IntSlider(armorProp, 0, 100, new GUIContent("Armor"));

        if (!armorProp.hasMultipleDifferentValues)
            ProgressBar(armorProp.intValue / 100.0f, "Armor");

        EditorGUILayout.PropertyField(gunProp, new GUIContent("Gun Object"));

        serializedObject.ApplyModifiedProperties();
    }

    void ProgressBar(float value, string label)
    {
        Rect rect = GUILayoutUtility.GetRect(18, 18, "TextField");
        EditorGUI.ProgressBar(rect, value, label);
        EditorGUILayout.Space();
    }
}