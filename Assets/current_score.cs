using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class current_score : MonoBehaviour
{



    private Dictionary<int, Image> Mapped_ui_numbers = new();

    private int Players_score;
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

    public List<Image> SeperateDigits()
    {
        string scoreStr = Players_score.ToString();

        List<Image> hold_my_images = new();

        foreach (char c in scoreStr)
        {
            int digit = c - '0';  // Convert char '5' → int 5
            Image digitImage = Mapped_ui_numbers[digit];
            // Create and show this digit image
            hold_my_images.Add(digitImage);
        }
        return hold_my_images;
    }
    private void Populate_dictionary()
    {
        for (int i = 0; i < 10; i += 1)
        {
            Mapped_ui_numbers.Add(i, numbers_ui[i]);
        }

    }
}
