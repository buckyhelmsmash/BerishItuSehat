using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{

    public GameObject EndgameBox;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("organicTrash") == null && GameObject.FindWithTag("anorganicTrash") == null)
        {
            Debug.Log("TIDAK ADA SAMPAH");
            EndgameBox.SetActive(true);
        }
        else
        {
            Debug.Log("ADA SAMPAH");
        }
    }
}
