using UnityEditor;


[CustomEditor(typeof(Hoge))]
public class HogeEditor : Editor
{
    bool foldPiyo = true;
    bool foldFuga = true;

    public override void OnInspectorGUI()
    {
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        foldPiyo = CustomUI.Foldout("Piyo", foldPiyo);
        if (foldPiyo)
        {
            Hoge hoge = (Hoge)target;

            hoge.piyo = EditorGUILayout.Toggle("piyo", hoge.piyo);
            hoge.qiyo = EditorGUILayout.IntField("qiyo", hoge.qiyo);
            hoge.riyo = EditorGUILayout.TextField("riyo", hoge.riyo);
        }

        EditorGUILayout.Space();

        foldFuga = CustomUI.Foldout("Fuga", foldFuga);
        if (foldFuga)
        {
            Hoge hoge = (Hoge)target;

            hoge.fuga = EditorGUILayout.Toggle("fuga", hoge.fuga);
            hoge.guga = EditorGUILayout.IntField("guga", hoge.guga);
            hoge.huga = EditorGUILayout.TextField("huga", hoge.huga);
        }

        EditorGUILayout.Space();
    }
}