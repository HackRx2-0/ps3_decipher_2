using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnHomeButtonClicked()
    {
        SceneManager.LoadScene("GameScene2");
    }

    // Update is called once per frame
    public void OnReplayButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
