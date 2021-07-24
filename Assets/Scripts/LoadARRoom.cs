using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadARRoom : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnARRoomEnterButtonClicked()
    {
        SceneManager.LoadScene("GameScene2");
    }

}
