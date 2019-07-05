using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
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
}
