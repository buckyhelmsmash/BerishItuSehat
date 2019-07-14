using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManagerBudiWati : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public TextMeshProUGUI GameHintText;
    public string[] sentences;
    public AudioSource[] dialog;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject dialogueBox;
    public GameObject Wati;
    public GameObject Camera;
    public GameObject Gameplay;


    void Start()
    {
        Camera.transform.position = new Vector3(3, 0, -10);
        Camera.GetComponent<Camera>().orthographicSize = 2.5F;
        GameHintText.enabled = false;
        StartCoroutine(Type());
        Wati.GetComponent<Animator>().SetBool("Talk", true);
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
            if (Input.GetMouseButtonDown(0))
                NextSentence();
        }
    }

    IEnumerator Type()
    {
        dialog[index].Play();
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
            if (index == 1)
                Wati.GetComponent<Animator>().SetBool("Talk", false);
        }
        else
        {
            dialog[2].Play();
            textDisplay.text = "";
            dialogueBox.SetActive(false);
            Camera.transform.position = new Vector3(0, 0, -10);
            Camera.GetComponent<Camera>().orthographicSize = 5F;
            Camera.GetComponent<OutlineManager>().enabled = true;
            GameHintText.enabled = true;
            for (var index = 0; index < Gameplay.GetComponentsInChildren<PolygonCollider2D>().Length; index++)
            {
                Gameplay.GetComponentsInChildren<PolygonCollider2D>()[index].enabled = true;
            }
            for (var index = 0; index < Gameplay.GetComponentsInChildren<Clicked>().Length; index++)
            {
                Gameplay.GetComponentsInChildren<Clicked>()[index].enabled = true;
            }
        }
    }
}
