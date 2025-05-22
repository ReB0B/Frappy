using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text textScore;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        textScore.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

}
