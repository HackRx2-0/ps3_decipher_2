using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARRoomButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("OpenLayout");
    }

    // Update is called once per frame
    public void OnGameButtonClicked()
    {
        SceneManager.LoadScene("TimerPop");
    }
}
