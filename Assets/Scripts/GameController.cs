using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController Instance { get; private set; }
    public GameObject ReplayButton;
    public GameObject GameOverText;
    public GameObject BossTimeText;
    public GameObject UffeMeh;
    public GameObject UffeHappy;
    public GameObject UffeSerious;
    public static bool GameOver = false;
    public static bool Kill = false;

    private void Update()
    {
        if (Kill)
        {
            BossTimeText.SetActive(false);
            UffeHappy.SetActive(true);
            UffeSerious.SetActive(false);
        }
        else if (GameOver)
        {
            GameOverText.SetActive(true);
            ReplayButton.SetActive(true);
            UffeMeh.SetActive(true);
            Time.timeScale = 0;
            SpawnMonstersController.bossTime = false;
            int highScore = ScoreController.Score;

            if (PlayerPrefs.HasKey("highScore")){
                if (highScore > PlayerPrefs.GetInt("highScore"))
                {
                    PlayerPrefs.SetInt("highScore", highScore);
                    PlayerPrefs.Save();
                }
            }
            else
            {
                    PlayerPrefs.SetInt("highScore", highScore);
                    PlayerPrefs.Save();
            }
        }
        else
        {
            Time.timeScale = 1;
            UffeSerious.SetActive(true);
            UffeHappy.SetActive(false);

            if(ScoreController.Score > 15 && SpawnMonstersController.bossTime == false)
            {
                SpawnMonstersController.bossTime = true;
                BossTimeText.SetActive(true);
            }
        }  

    }
    
    
    public void OnButtonClick()
    {
        GameOver = false;
        ScoreController.Score = 0;
        SceneManager.LoadScene(0);

    }

}