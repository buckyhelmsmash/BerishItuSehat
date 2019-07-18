using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DragScript : MonoBehaviour
{
    private Vector2 initialPosition, mousePosition;
    private float deltaX, deltaY;
    private GameObject Bin;
    private GameObject OppositeBin;
    public GameObject OrganicBin;
    public GameObject AnorganicBin;
    public AudioSource goodjob;
    public AudioSource crybaby;
    private void Start()
    {
        
        
        if (gameObject.tag == "organicTrash")
        {
            Bin = OrganicBin;
            OppositeBin = AnorganicBin;
        }
        else
        {
            Bin = AnorganicBin;
            OppositeBin = OrganicBin;
        }

        initialPosition = transform.position;
    }

    private void OnMouseDown()
    {

        deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }
    private void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - Bin.transform.position.x) <= 5f / 6f &&
            Mathf.Abs(transform.position.y - Bin.transform.position.y) <= 9f / 10f)
        {
            Debug.Log("benar");
            StartCoroutine(BinAnimateHappy());
            goodjob.Play();
        }
        else if (Mathf.Abs(transform.position.x - OppositeBin.transform.position.x) <= 5f / 6f &&
            Mathf.Abs(transform.position.y - OppositeBin.transform.position.y) <= 9f / 10f)
        {
            Debug.Log("Salah");
            StartCoroutine(BinAnimateSad());
            crybaby.Play();
        }
        else
        {
            transform.position = initialPosition;
        }

    }
    IEnumerator BinAnimateHappy()
    {
        ScoreManager.scorevalue += 10;
        Bin.GetComponent<Animator>().SetBool("Happy", true);
        transform.position = Bin.transform.position;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(1);
        Bin.GetComponent<Animator>().SetBool("Happy", false);
        Destroy(gameObject);
    }

    IEnumerator BinAnimateSad()
    {
        ScoreManager.scorevalue -= 10;
        OppositeBin.GetComponent<Animator>().SetBool("Sad", true);
        transform.position = initialPosition;
        yield return new WaitForSeconds(1);
        OppositeBin.GetComponent<Animator>().SetBool("Sad", false);
    }



}