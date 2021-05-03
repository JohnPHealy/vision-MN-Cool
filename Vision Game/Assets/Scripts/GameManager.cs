using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private UnityEvent<string> addScore;
    private Vector3 checkPointPos;
    private int score;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;

    private void Start()
    {
        isGameActive = true;
        checkPointPos = player.transform.position;
        score = 0;
        UpdateUI();
        PauseGame();
    }

    public void RespawnPlayer()
    {
        player.transform.position = checkPointPos;
        score = 0;
        UpdateUI();
    }

    public void AddScore(int scoreAmt)
    {
        score += scoreAmt;
        UpdateUI();
    }

    private void UpdateUI()
    {
        addScore.Invoke(score.ToString());
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}