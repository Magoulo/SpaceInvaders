using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static ScoreController Instance { get; private set; }
    public static int Score = 0;
    private int highScore;
    public Text ScoreText;
    public Text HighScoreText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            highScore = PlayerPrefs.GetInt("highScore");
            HighScoreText.text = highScore.ToString();
        }
    }
    private void Update()
    {
        ScoreText.text = Score.ToString();
        if(Score > highScore)
        {   
            HighScoreText.text = Score.ToString();
        }
    }


}
