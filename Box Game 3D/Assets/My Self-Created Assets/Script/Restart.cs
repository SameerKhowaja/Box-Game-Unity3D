using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Text TScore;
    private string st;

    void Update()
    {
        Invoke("Restarter", 1f);
    }

    void Restarter()
    {
        SceneManager.LoadScene("MainScene");
    }
    
}
