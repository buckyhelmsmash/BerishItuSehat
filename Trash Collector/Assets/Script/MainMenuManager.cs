using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject Menu, Credit;
    // Start is called before the first frame update
    public void KategoriSampah()
    {
        SceneManager.LoadScene("KategoriSampah");
    }
    public void BudiWati()
    {
        SceneManager.LoadScene("Budi&Wati");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Credits()
    {
        Menu.SetActive(false);
        Credit.SetActive(true);
    }
    public void MainMenu()
    {
        Menu.SetActive(true);
        Credit.SetActive(false);
    }
}
