using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // to use UI
using UnityEngine.SceneManagement; // to use another scence

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;
    int score = 0;

    public Text scoreText;
    public GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        gameOver = true;

        //get game object and use their script to invoke by one line
        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();

        gameOverPanel.SetActive(true);
    }

    public void IncreementScore()
    {
        if(!gameOver)
        {
            score++;
            scoreText.text = score.ToString();

            print(score);
        }
    }

    public void Retart()
    {
        SceneManager.LoadScene("Game"); //load the scence name "Game"
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu"); //load the scence name "MainMenu"
    }
}
