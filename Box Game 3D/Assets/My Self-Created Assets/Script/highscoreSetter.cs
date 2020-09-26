using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscoreSetter : MonoBehaviour
{
    public Text Score;
    public Text HighScore;
    void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }
    
    void Update()
    {
        int curScore = int.Parse(Score.text);
        int highScr = int.Parse(HighScore.text);
        if (highScr < curScore)
        {
            HighScore.text = curScore.ToString();
            PlayerPrefs.SetInt("highscore", curScore);
        }
    }
}
