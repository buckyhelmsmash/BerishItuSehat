using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{

    public GameObject Endgame;
    public GameObject Ingame;
    public GameObject Stars;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("organicTrash") == null && GameObject.FindWithTag("anorganicTrash") == null)
        {
            Endgame.SetActive(true);
            Ingame.SetActive(false);
            Stars.SetActive(true);
        }
    }
}
