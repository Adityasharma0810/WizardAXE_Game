using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public TMP_Text gameOverScoreText; // Drag your Game Over Text here

    private bool isGameOver = false;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        // Listen for Enter key only after game over
        if (isGameOver && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
    }

    public void UpdateGameOverText()
    {
        gameOverScoreText.text = "Game Over\nScore: " + score +"\nPress Entre \nto \nPlay Again =]";
        isGameOver = true; // Enable Enter-to-restart
    }
}