using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucing : MonoBehaviour
{
    public float Speed;
    public Vector3 start, finish;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < start.x)
        {
            Right();
        }
        if (transform.position.x > finish.x)
        {
            Left();
        }

    }
    void Right()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
    }
    void Left()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }
}
