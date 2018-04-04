using UnityEditor;


[CustomEditor(typeof(Hoge))]
public class HogeEditor : Editor
{
    bool fold = true;

    public override void OnInspectorGUI()
    {

        fold = CustomUI.Foldout("Hoge", fold);
        if (fold)
        {
            Hoge hoge = (Hoge)target;

            hoge.moge = EditorGUILayout.Toggle("moge", hoge.moge);
            hoge.fuga = EditorGUILayout.IntField("fuga", hoge.fuga);
            hoge.piyo = EditorGUILayout.TextField("piyo", hoge.piyo);
        }
    }
}