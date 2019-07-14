using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{

    public GameObject EndgameBox;
    public GameObject Stars;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("organicTrash") == null && GameObject.FindWithTag("anorganicTrash") == null)
        {
            EndgameBox.SetActive(true);
            Stars.SetActive(true);
        }
    }
}
