using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float Speed;
    public GameObject EndBox;
    public GameObject LoseText;
    public AudioSource Sad;
    public AudioSource Aduh;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "banana")
        {
            Aduh.Play();
            gameObject.GetComponent<Animator>().SetBool("Fall", true);
            Speed = 0;
        }
        if (other.tag == "Budi")
        {
            gameObject.GetComponent<Animator>().SetBool("Stop", true);
            Speed = 0;
            EndBox.SetActive(true);
            LoseText.SetActive(false);
            Sad.Play();
        }
    }
}
