﻿using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class Rotate : MonoBehaviour
{
    public UnityEvent Event; 

    public GameObject obj;
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
    [ExecuteInEditMode]
    public void SetObj( GameObject go)
    {
       obj = go;
    }
}