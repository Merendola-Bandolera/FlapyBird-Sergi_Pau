using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreUpdate : MonoBehaviour
{

    public int score = 0;
    int difficultyMeter;
    [SerializeField] GameObject pipeGenerator;

    [SerializeField] TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + score;
    }

    public void ScoreSum()
    {
        if (Time.timeScale == 1)
        {
            score += 1;
            difficultyMeter += 10;
            if (difficultyMeter >= 10)
            {
                difficultyMeter = 0;
                pipeGenerator.GetComponent<DifficultyManager>().IncreaseDifficulty();
            }
        }
    }

}
