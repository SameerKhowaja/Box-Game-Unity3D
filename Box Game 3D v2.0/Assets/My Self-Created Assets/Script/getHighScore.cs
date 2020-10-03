using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getHighScore : MonoBehaviour
{
    public Text highscore;

    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }
}
