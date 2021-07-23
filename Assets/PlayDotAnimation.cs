using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDotAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        GetComponent<Animator>().Play("DotAnimation_Play");

    }

    
}
