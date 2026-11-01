using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public TMP_Text scoreText;
    public TMP_Text livesText;
    public TMP_Text finalScoreText;
    public GameObject gameOverPanel;

    int score = 0;
    int lives = 3;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateUI();
        gameOverPanel.SetActive(false);
    }

    public void AddScore()
    {
        score++;
        UpdateUI();
    }

    public void LoseLife()
{
    if (lives <= 0) return;

    lives--;
    UpdateUI();

    if (lives == 0)
    {
        GameOver();
    }
}

    void GameOver()
    {
        finalScoreText.text = "Final Score: " + score;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}