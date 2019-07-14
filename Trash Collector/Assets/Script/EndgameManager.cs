using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndgameManager : MonoBehaviour
{
    public AudioSource Applause;
    // Start is called before the first frame update
    private void Start()
    {
        Applause.Play();
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
