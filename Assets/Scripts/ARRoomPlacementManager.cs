using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class ARRoomPlacementManager : MonoBehaviour
{
    public delegate void ObjectSpawnManager(Vector3 spawnPosition);
    public static event ObjectSpawnManager OnObjectSpawned;
    public GameObject sectionInfoActivator;
    [SerializeField]
    private GameObject roomPrefab;
    [SerializeField]
    private Camera arCam;
    ARPlaneManager aRPlaneManager;
    private Vector2 touchPosition = default;
    private ARRaycastManager aRRaycastManager;
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private bool objectIsSpawned = false;
    [SerializeField]
    private GameObject planeDetectionPanel;

    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
        Debug.Log("ARRoomPlacement script is enabled");
    }

    void Update()
    {
        Debug.Log($"Number of planes detected is {aRPlaneManager.trackables.count}");
        
        if(aRPlaneManager.trackables.count == 0)
        {

            planeDetectionPanel.SetActive(true);
            Debug.Log("Wait while we are detecting the planes. Point your camera towards your floor, and hold it stable");
            return;
        }
        else
        {
            planeDetectionPanel.SetActive(false);
            Debug.Log("Planes are detected");
        }
        
        if (Input.touchCount == 0)
            return;
        RaycastHit hit;
        Ray ray = arCam.ViewportPointToRay(new Vector3(0.5f,0.5f));
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began)
        {
            touchPosition = touch.position;
            if (aRRaycastManager.Raycast(touchPosition, hits))
            {
                if (Physics.Raycast(ray, out hit))
                {
                    
                    if (hit.collider.gameObject.CompareTag("ARPlane"))
                    {
                        Debug.Log("Plane");
                        objectIsSpawned = true;
                        var hitPose = hits[0].pose;
                        Instantiate(roomPrefab, hitPose.position, hitPose.rotation);
                        sectionInfoActivator.SetActive(true);
                        foreach (ARPlane aRPlane in aRPlaneManager.trackables)
                        {
                            aRPlane.gameObject.SetActive(false);
                        }
                        Destroy(aRPlaneManager);
                        return;
                    }
                  
                }
                
            }


        }        
    }
}
