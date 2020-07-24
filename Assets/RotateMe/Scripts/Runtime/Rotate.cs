using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;
public class Rotate : MonoBehaviour
{
    public UnityEvent Event; 

    public static GameObject obj;
    public float angularVol = 10;
    public GameObject GORot;
    private void Start()
    {
        GORot = Instantiate(obj, transform);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Event.Invoke();
        }
         
        if (GORot == null) return;
        var rot = Quaternion.AngleAxis(angularVol * Time.deltaTime, Vector3.up);
        GORot.transform.localRotation = rot * GORot.transform.localRotation;
    }
    [MenuItem("AssetDatabase/LoadAssetExample")]
    public static void SetObj()
    {
        GameObject go = AssetDatabase.LoadAssetAtPath<GameObject>("Package/com.autocore.rotate-me/Prefabs/Cube.prefab");
        Debug.Log(Path.GetFileName("Package / com.autocore.rotate - me / Prefabs / Cube.prefab"));
        if (go == null) Debug.Log("null");
        else Debug.Log(go.name);
        Instantiate(go);
        obj = go;
    }
}
