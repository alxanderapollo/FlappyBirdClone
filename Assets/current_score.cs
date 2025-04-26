using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class current_score : MonoBehaviour
{



    private Dictionary<int, Image> Mapped_ui_numbers = new();

    private static int Players_score;
    [SerializeField] private List<Image> numbers_ui;


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //1. populate the the user score as 0 and then save all the images into the dictionary


    void Awake()
    {
        Players_score = 0;
        Populate_dictionary();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int SeperateDigits(int userscore)
    {
        int score = playerScore;

        while (score > 0)
        {
            int lastDigit = score % 10;  // Grab the last digit
            score /= 10;                 // Remove the last digit

            Image digitImage = Mapped_ui_numbers[lastDigit];
            // Create and show this digit image
        }
        return 0;


    }
    private void Populate_dictionary()
    {
        for (int i = 0; i < 10; i += 1)
        {
            Mapped_ui_numbers.Add(i, numbers_ui[i]);

        }

    }
}
