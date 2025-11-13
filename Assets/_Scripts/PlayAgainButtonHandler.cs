using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    private bool isGameOver = false;

    void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.Return)) // Enter key
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void TriggerGameOver()
    {
        isGameOver = true;
    }
}