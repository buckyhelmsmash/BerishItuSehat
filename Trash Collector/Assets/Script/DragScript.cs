using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DragScript : MonoBehaviour
{
    private Vector2 initialPosition, mousePosition;
    private float deltaX, deltaY;
    private Vector2 Bin;


    private void Start()
    {
        if (gameObject.tag == "organicTrash")
            Bin = GameObject.FindWithTag("organicBin").transform.position;
        else
            Bin = GameObject.FindWithTag("anorganicBin").transform.position;
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
        if (Mathf.Abs(transform.position.x - Bin.x) <= 5f / 6f &&
            Mathf.Abs(transform.position.y - Bin.y) <= 9f / 10f)
        {
            transform.position = Bin;
            Destroy(gameObject);
        }
        else
        {
            transform.position = initialPosition;
        }

    }
}