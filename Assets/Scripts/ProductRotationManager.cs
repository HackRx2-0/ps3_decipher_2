using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductRotationManager : MonoBehaviour
{
    Vector3 targetVal = Vector3.zero;
    
    void Update()
    {
        gameObject.transform.LookAt(Camera.main.transform);
        targetVal = gameObject.transform.localEulerAngles;
        targetVal.x = 0;
        targetVal.z = 0;
        transform.localEulerAngles = targetVal;
    }
}
