using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class current_score : MonoBehaviour
{

    private int Players_score = 0;
    [SerializeField] private TextMeshProUGUI runningPlayerScore;

    void Update()
    {
        UpdateUi();

    }
    public void UpdateUi()
    {

        runningPlayerScore.text = ": " + Score.score.ToString();
    }
}
