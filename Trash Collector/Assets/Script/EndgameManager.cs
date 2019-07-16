using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndgameManager : MonoBehaviour
{
    public GameObject Trophy, Candy;
    public AudioSource Applause;
    public TextMeshProUGUI ScoreDisplay;
    // Start is called before the first frame update
    private void Start()
    {
        Applause.Play();
        ScoreDisplay.text = "SCORE KAMU: " + ScoreManager.scorevalue;
        if (ScoreManager.scorevalue < 100)
            Trophy.SetActive(false);
        else
            Candy.SetActive(false);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("KategoriSampah");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
