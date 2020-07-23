using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class Rotate : MonoBehaviour
{
    public UnityEvent Event; 

    public GameObject obj;
    public float angularVol = 10;
    GameObject GORot;
    private void Start()
    {
        if (obj == null)
            obj = AssetDatabase.LoadAssetAtPath<GameObject>("Package/com.autocore.rotate-me/Prefabs/Cube.prefab");
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
}
