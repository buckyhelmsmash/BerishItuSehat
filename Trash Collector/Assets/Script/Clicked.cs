using UnityEngine;
using UnityEditor;

public class Clicked : MonoBehaviour
{
    public GameObject EndBox;
    public GameObject WinText;
    public GameObject LoseText;
    public GameObject Stars;
    private void Start()
    {

    }
    private void Update()
    {

    }
    private void OnMouseDown()
    {
        this.GetComponent<Renderer>().material.color = Color.gray;
        EndBox.SetActive(true);
        if (gameObject.tag == "Trash")
        {
            Stars.SetActive(true);
            WinText.SetActive(false);

        }
        else
        {
            LoseText.SetActive(false);
        }
    }

}
