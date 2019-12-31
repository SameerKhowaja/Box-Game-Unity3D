using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
    public float timer;
    public float score;
    public Text TScore;
    public Scores sc;
    public Restart rst;
    public enemyMovement em;
    private string Fscore;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        timer += Time.deltaTime;

        if (timer > 1f)
        {
            Fscore = TScore.text;
            score += 1;
            //We only need to update the text if the score changed.
            TScore.text = "SCORES : " + score.ToString();
            //Reset the timer to 0.
            timer = 0;

            if (em.force == 0f)
            {
                TScore.text = Fscore;
                rst.enabled = true;
                sc.enabled = false;
            }
        }
        
    }

}
