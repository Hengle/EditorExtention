using UnityEditor;
using UnityEngine;

public class MyPlayerAlternative : MonoBehaviour
{
    public int damage;
    public int armor;
    public GameObject gun;
}


[CustomEditor(typeof(MyPlayerAlternative))]
public class MyPlayerEditorAlternative : Editor
{
    public override void OnInspectorGUI()
    {
        MyPlayerAlternative mp = (MyPlayerAlternative)target;

        mp.damage = EditorGUILayout.IntSlider("Damage", mp.damage, 0, 100);
        ProgressBar(mp.damage / 100.0f, "Damage");

        mp.armor = EditorGUILayout.IntSlider("Armor", mp.armor, 0, 100);
        ProgressBar(mp.armor / 100.0f, "Armor");

        bool allowSceneObjects = !EditorUtility.IsPersistent(target);
        mp.gun = (GameObject)EditorGUILayout.ObjectField("Gun Object", mp.gun, typeof(GameObject), allowSceneObjects);
    }

    void ProgressBar(float value, string label)
    {
        Rect rect = GUILayoutUtility.GetRect(18, 18, "TextField");
        EditorGUI.ProgressBar(rect, value, label);
        EditorGUILayout.Space();
    }
}