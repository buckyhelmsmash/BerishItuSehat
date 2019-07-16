using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int scorevalue = 0;
    public TextMeshProUGUI ScoreDisplay;
    public TextMeshProUGUI HighscoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        ScoreDisplay.text = "Score: " + scorevalue;
        HighscoreDisplay.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = "Score: " + scorevalue;
        if (scorevalue > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", scorevalue);
            HighscoreDisplay.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0);
        }
    }
}
