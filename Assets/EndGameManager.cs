using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void RestartGame()
    {
        Time.timeScale = 1f;  // Reset time in case the game is paused
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.score = 0;
    }
    public void QuitGame()
    {
        Time.timeScale = 1f;  // Optional: reset time
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;  // For Editor
#else
    Application.Quit();  // For builds
#endif
    }

}
