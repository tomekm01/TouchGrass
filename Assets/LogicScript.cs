using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int Score;
    public Text scoreText;
    public GameObject gameOver;
    public GameObject grassSpawner;
    public GameObject grassPrefab;
    public Text scoreTextGameOver;

    [ContextMenu("Dodaj punkcior")]
    public void addScore()
    {
        Score = Score + 1;
        scoreText.text = Score.ToString();
    }

    public void gameOverScreen()
    {
        gameOver.SetActive(true);
        grassSpawner.SetActive(false);
        grassPrefab.SetActive(false);
        scoreTextGameOver.text = Score.ToString();
        scoreText.text = "";
    }

    public void quit()
    {
        Application.Quit();
    }

    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
