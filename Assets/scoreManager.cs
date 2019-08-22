using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public static int points = 0;
    public TextMeshProUGUI scoreText;
    public static bool playGame = false;

    Text text;
    void Awake()
    {
        text = GetComponent<Text>();
    }

    public void addScore()
    {
        points++;
    }
    // Update is called once per frame
    void Update()
    {

        if (points == 2)
        {
            scoreText.text = "GAMEOVER!";
        }
        else
        {
            scoreText.text = "Score: " + points;
        }
    }
}