using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class InstrucionButtonClickManager : MonoBehaviour
{
    [SerializeField]
    private GameObject parent;
    public void OnOkButtonClick()
    {
        parent.SetActive(false);
        FindObjectOfType<ARPlacementManager>().enabled = true;
        FindObjectOfType<ARPlaneManager>().enabled = true;
    }

}
