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
        
        DirectoryInfo direction = new DirectoryInfo(Path.GetFullPath(Environment.CurrentDirectory));
        Debug.Log(direction.FullName);
        FileInfo[] files = direction.GetFiles("*.prefab", SearchOption.AllDirectories);

        Debug.Log(files.Length);
        for (int i = 0; i < files.Length; i++)
        {
            if (files[i].Name.EndsWith(".meta"))
            {
                continue;
            }
            Debug.Log("Name:" + files[i].Name);
            //Debug.Log("FullName:" + files[i].FullName);
            //Debug.Log("DirectoryName:" + files[i].DirectoryName);

        }
        //if (obj==null)
        //    obj = (GameObject)AssetDatabase.LoadAssetAtPath("Package/com.autocore.rotate-me/Prefabs/Cube.prefab", typeof(GameObject));
        //GORot =Instantiate(obj, transform);
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
