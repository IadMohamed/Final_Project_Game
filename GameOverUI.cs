using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // Reload the previous scene
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene"); // Replace with your Main Menu scene name
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit(); // Works in the built application, not in the editor
    }
}

