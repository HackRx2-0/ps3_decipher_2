using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductCollisionManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Product"))
        {
            Destroy(collision.gameObject);
        }
    }
}
