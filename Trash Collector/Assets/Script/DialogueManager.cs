using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public AudioSource[] dialog;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject dialogueBox;
    public GameObject Trash;

    private BoxCollider2D[] TrashCollider;

    void Start()
    {
        StartCoroutine(Type());
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
        }
        else
        {
            dialog[4].Play();
            textDisplay.text = "";
            dialogueBox.SetActive(false);
            TrashCollider = Trash.GetComponentsInChildren<BoxCollider2D>();
            for (var index = 0; index < TrashCollider.Length; index++)
            {
                TrashCollider[index].enabled = true;

            }

        }
    }
}
