﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainScreen : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("lvl01");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
