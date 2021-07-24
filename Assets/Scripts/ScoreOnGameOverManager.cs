using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreOnGameOverManager : MonoBehaviour
{
    [SerializeField]
    private GameObject updateScoreObject;
    private UpdateScore updateScore;
    private TextMeshProUGUI finalScore;
    void Start()
    {
        finalScore = GetComponent<TextMeshProUGUI>();
        updateScore = updateScoreObject.GetComponent<UpdateScore>();
        finalScore.text = updateScore.ScoreString;

    }
    private void Update()
    {
        finalScore.text = updateScore.ScoreString;
    }

}
