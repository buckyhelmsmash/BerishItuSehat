using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class BudiWatiManager : MonoBehaviour
{

    private void Start()
    {

    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Budi&Wati");
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
