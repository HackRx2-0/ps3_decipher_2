using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject rockPrefab;
    private float maxX = 4f, minX = -8.8f;
    private float maxZ = 7.8f, minZ = 0f;

    void OnEnable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
