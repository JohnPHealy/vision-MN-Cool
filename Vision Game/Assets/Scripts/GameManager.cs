using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private UnityEvent<string> addScore;
    private Vector3 checkPointPos;
    private int score;

    private void Start()
    {
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
}
