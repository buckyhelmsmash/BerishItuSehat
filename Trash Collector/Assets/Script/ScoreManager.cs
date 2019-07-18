using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int scorevalue = 0;
    public TextMeshProUGUI ScoreDisplay;
    public TextMeshProUGUI HighscoreDisplay;
    public TextMeshProUGUI LeaderboardDisplay;
    public static List<int> Leaderboard = new List<int>(10);
    public GameObject LeaderboardPanel;
    bool Show_Panel = false;
    // Start is called before the first frame update
   
    void Start()
    {
        ScoreDisplay.text = "Score: " + scorevalue;
        HighscoreDisplay.text = "Highscore" ;
        // PlayerPrefs.SetInt("Highscore1", 123);
        // PlayerPrefs.SetInt("Highscore2", 45);
        // PlayerPrefs.SetInt("Highscore3", 123);
        // PlayerPrefs.SetInt("Highscore4", 346);
        // PlayerPrefs.SetInt("Highscore5", 234);
        // PlayerPrefs.SetInt("Highscore6", 45);
        // PlayerPrefs.SetInt("Highscore7", 678);
        // PlayerPrefs.SetInt("Highscore8", 123);
        // PlayerPrefs.SetInt("Highscore9", 235);
        // PlayerPrefs.SetInt("Highscore10", 456);


    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = "Score: " + scorevalue;
        // if (scorevalue > PlayerPrefs.GetInt("Highscore"))
        // {
        //     PlayerPrefs.SetInt("Highscore", scorevalue);
        //     HighscoreDisplay.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0);
        // }
    }

    void getLeaderboardtoList()
    {
        Leaderboard.Clear();
        for (int i = 0; i < 10; i++)
        {
            Leaderboard.Add(PlayerPrefs.GetInt("Highscore" + (i + 1), 0));
        }
        Leaderboard.Sort();
        Leaderboard.Reverse();
        for (int i = 0; i < 10; i++)
        {
            PlayerPrefs.SetInt("Highscore" + (i + 1), Leaderboard[i]);
        }
    }
    public void AddScoreToLeaderboard()
    {
        Leaderboard.Add(ScoreManager.scorevalue);
        Leaderboard.Sort();
        Leaderboard.Reverse();
        for (int i = 0; i < 10; i++)
        {
            PlayerPrefs.SetInt("Highscore" + (i + 1), Leaderboard[i]);
        }
    }
    public void ShowPanel()
    {
        Show_Panel = !Show_Panel;
        LeaderboardPanel.SetActive(Show_Panel);
        getLeaderboardtoList();
        ShowList();
    }
    public void ShowList()
    {
        if (Show_Panel == true)
        {
            for (int i = 0; i < 10; i++)
            {
                LeaderboardDisplay.text += (i + 1) + ". " + PlayerPrefs.GetInt("Highscore" + (i + 1), 0) + "\n";
            }
        }
        else
        {
            LeaderboardDisplay.text = "";
        }
    }
}