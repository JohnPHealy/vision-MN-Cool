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
    [SerializeField] private GameObject boss;
    [SerializeField] private UnityEvent<string> addScore;
    private Vector3 checkPointPos;
    public GameObject title;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreValue;
    public GameObject pauseMenu;
    private int score;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject coinsfx;
    public TextMeshProUGUI coinText;
    public Button resumeButton;
    public GameObject heart;
    public GameObject heart1;
    public GameObject heart2;

    private void Start()
    {
        isGameActive = false;
        Time.timeScale = 0;
        checkPointPos = player.transform.position;
        score = 0;
        title.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(false);
        scoreValue.gameObject.SetActive(false);
        pauseMenu.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        isGameActive = true;
        player.GetComponent<AudioSource>().enabled = true;
        title.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        scoreValue.gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive(true);
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
        player.GetComponent<AudioSource>().enabled = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Finish()
    {
        player.GetComponent<AudioSource>().enabled = false;
        SceneManager.LoadScene("VictoryScene");
    }

    public void CoinCollect()
    {
        Time.timeScale = 0;
        isGameActive = false;
        coinsfx.GetComponent<AudioSource>().enabled = true;
        coinText.gameObject.SetActive(true);
        resumeButton.gameObject.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        isGameActive = true;
        coinText.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(false);
    }

    public void BossHealth()
    {
        heart.gameObject.SetActive(true);
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
    }

    public void LoseHeart1()
    {
        heart.gameObject.SetActive(false);
    }

    public void LoseHeart2()
    {
        heart1.gameObject.SetActive(false);
    }

    public void LoseHeart3()
    {
        heart2.gameObject.SetActive(false);
    }
}