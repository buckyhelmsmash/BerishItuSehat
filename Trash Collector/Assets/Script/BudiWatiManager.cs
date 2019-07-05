using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BudiWatiManager : MonoBehaviour
{
    public GameObject EndGameBox;
    public void RestartGame()
    {
        SceneManager.LoadScene("Budi&Wati");
    }
}
