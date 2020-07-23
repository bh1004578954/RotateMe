using System.Collections;
using System.Collections.Generic;
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
            rotate.SetObj(); ;
        }
    }
}
