using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Rotate))]
public class Editor_Rotate : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Rotate rotate = (Rotate)target ;

        if (GUILayout.Button("Set obj"))
        {
            GameObject g = AssetDatabase.LoadAssetAtPath<GameObject>("Package/com.autocore.rotate-me/Prefabs/Cube.prefab");
            Debug.Log(Path.GetFileName("Package / com.autocore.rotate - me / Prefabs / Cube.prefab"));
            Instantiate(g);
            rotate.SetObj(g); 
        }
    }
}
