using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenuPanel; // Panel that holds the UI elements
    public Slider volumeSlider;       // Slider for volume control
    private bool isPaused = false;

    private void Start()
    {
        // Initialize the volume slider value based on the player's preferences or default value
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f); // Default volume is 1
        AudioListener.volume = volumeSlider.value; // Set initial volume
    }

    // Function to toggle the pause menu
    public void TogglePauseMenu()
    {
        isPaused = !isPaused;
        pauseMenuPanel.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0;  // Pause the game
        }
        else
        {
            Time.timeScale = 1;  // Resume the game
        }
    }

    // Resume the game (called by the Resume Button)
    public void ResumeGame()
    {
        TogglePauseMenu();  // Close the pause menu and resume the game
    }

    // Restart the game (called by the Restart Button)
    public void RestartGame()
    {
        Time.timeScale = 1;  // Ensure the game is running again
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Reload the current scene
    }

    // Adjust volume based on the slider value (called by the Volume Slider)
    public void AdjustVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume); // Save the volume preference
    }
}
