using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text text_score;
    public Text text_gameOver;
    public int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
    {
        playerScore++;
        text_score.text = "Score: " + playerScore.ToString();
    }

    public void playerDie()
    {
        text_gameOver.enabled = true;
        Time.timeScale = 0;
    }
}
