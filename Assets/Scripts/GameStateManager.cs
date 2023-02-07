using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStateManager : MonoBehaviour
{
    [SerializeField]
    float gameSpeed = 6.0f;

    [SerializeField]
    int score = 0;

    TMP_Text scoreText;
    TMP_Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
        gameOverText = GameObject.Find("GameOverText").GetComponent<TMP_Text>();
        gameOverText.alpha = 0.0f;
    }

    public float GetGameSpeed()
    {
        return gameSpeed;
    }

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int value)
    {
        score += value;
        gameSpeed += 1.0f;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        gameSpeed = 0.0f;
        gameOverText.alpha = 1.0f;
    }
}
