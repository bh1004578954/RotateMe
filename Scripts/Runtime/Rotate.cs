using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float angularVol = 10;
    void Update()
    {
        var rot = Quaternion.AngleAxis(angularVol * Time.deltaTime, Vector3.up);
        transform.localRotation = rot * transform.localRotation;
    }
}
