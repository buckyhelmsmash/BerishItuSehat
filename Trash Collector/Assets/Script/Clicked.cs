﻿using UnityEngine;
using UnityEditor;

public class Clicked : MonoBehaviour
{
    public GameObject EndBox;
    public GameObject WinText;
    public GameObject LoseText;
    public GameObject GameHintText;
    public GameObject Stars;
    public GameObject Camera;
    public GameObject Budi_Run;
    public AudioSource Apllause;
    public AudioSource Help;
    public AudioSource dimanakah;
    private void OnMouseDown()
    {
        dimanakah.Stop();
        GameHintText.SetActive(false);
        this.GetComponent<Renderer>().material.color = Color.gray;
        if (gameObject.tag == "Trash")
        {
            EndBox.SetActive(true);
            Stars.SetActive(true);
            WinText.SetActive(false);
            Apllause.Play();
        }
        else if (gameObject.tag == "Jalan")
        {
            GameObject.FindGameObjectWithTag("BGHALAMAN").SetActive(false);
            Camera.transform.position = new Vector3(20, 0, -10);
            for (var index = 0; index < Budi_Run.GetComponentsInChildren<Run>().Length; index++)
            {
                Budi_Run.GetComponentsInChildren<Run>()[index].enabled = true;
            }
            Help.Play();
        }
        else
        {
            Help.Play();
            GameObject.FindGameObjectWithTag("BGJALAN").SetActive(false);
            Camera.transform.position = new Vector3(20, 0, -10);
            for (var index = 0; index < Budi_Run.GetComponentsInChildren<Run>().Length; index++)
            {
                Budi_Run.GetComponentsInChildren<Run>()[index].enabled = true;
            }
        }
    }


}
