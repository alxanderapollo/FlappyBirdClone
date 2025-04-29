using UnityEngine;
using TMPro;
public class GameOverManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI bestScoreText;
    [SerializeField] private CanvasGroup gameOverCanvas;

    public void Awake()
    {
        if (gameOverCanvas != null)
        {
            gameOverCanvas.alpha = 0f;        // Fully invisible at start
            gameOverCanvas.interactable = false;
            gameOverCanvas.blocksRaycasts = false;
        }
    }
    public void ShowGameOver()
    {
        int currentScore = Score.score;
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);

        if (currentScore > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", currentScore);
            PlayerPrefs.Save();
        }
        bestScoreText.text = ": " + Mathf.Max(currentScore, bestScore);
        if (gameOverCanvas != null)
        {
            gameOverCanvas.alpha = 1f;        // Fully invisible at start
            gameOverCanvas.interactable = true;
            gameOverCanvas.blocksRaycasts = true;
        }
        // if player clicks on restart - restart game and current score
        // player clicks on quit - quit out of the game 
    }

}
