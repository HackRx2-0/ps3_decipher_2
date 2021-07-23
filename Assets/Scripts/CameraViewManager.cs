using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewManager : MonoBehaviour
{
    void Update()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.transform.gameObject;
            Debug.Log(go.tag);
            if (go.CompareTag("Product"))
            {
                go.GetComponent<ProductInfoManager>().OpenInfo();
            }
            else
            {
                go.GetComponent<ProductInfoManager>().ClosedInfo();
            }
        }
    }
}
