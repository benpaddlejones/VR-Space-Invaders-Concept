using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public static int points = 0;
    public static int blockHealthScore = 100;
    public static int playerHealthScore = 100;
    private float barrierWidth;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverText;
    public static bool activeGame = false;
    public GameObject startButton;
    public Slider blockHealthSlider;
    public Slider playerHealthSlider;
    public GameObject Barrier1;
    public GameObject Barrier2;
    public GameObject Barrier3;
    public GameObject Barrier4;
    public GameObject Barrier5;

    Text text;
    void Awake()
    {
        text = GetComponent<Text>();
    }

    void flashGameOver()
    {
        gameOverText.SetActive(!gameOverText.activeSelf);
    }

    void Update()
    {
        startButton.SetActive(!scoreManager.activeGame);
        playerHealthSlider.value = playerHealthScore;
        blockHealthSlider.value = blockHealthScore;
        if (points >= 15)
        {
            if (activeGame)
            {
                InvokeRepeating("flashGameOver", 0.0f, 1.0f);
            }
            activeGame = false;
            scoreText.text = "Player Score: " + points;

        } else {
            scoreText.text = "Player Score: " + points;
            gameOverText.SetActive(false);
        }
        barrierWidth = 0.01f * blockHealthScore;
        if (blockHealthScore <= 0)
        {
            Barrier1.SetActive(false);
            Barrier2.SetActive(false);
            Barrier3.SetActive(false);
            Barrier4.SetActive(false);
            Barrier5.SetActive(false);
        }
        Barrier1.transform.localScale = new Vector3(barrierWidth, 2.0f, 0.75f);
        Barrier2.transform.localScale = new Vector3(barrierWidth, 2.0f, 0.75f);
        Barrier3.transform.localScale = new Vector3(barrierWidth, 2.0f, 0.75f);
        Barrier4.transform.localScale = new Vector3(barrierWidth, 2.0f, 0.75f);
        Barrier5.transform.localScale = new Vector3(barrierWidth, 2.0f, 0.75f);
    }
}