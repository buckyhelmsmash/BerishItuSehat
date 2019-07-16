using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pisang : MonoBehaviour
{
    bool rotate = false;
    public Vector3[] point = new Vector3[3];
    float count = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        point[1] = point[0] + (point[2] - point[0]) / 2 + Vector3.up * 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
            Rotate();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("PISANG");
        rotate = true;

    }
    void Rotate()
    {

        if (count < 1.0f)
        {
            count += 1.0f * Time.deltaTime;
            gameObject.transform.Rotate(0, 0, -(200 * Time.deltaTime));
            Vector3 m1 = Vector3.Lerp(point[0], point[1], count);
            Vector3 m2 = Vector3.Lerp(point[1], point[2], count);
            gameObject.transform.position = Vector3.Lerp(m1, m2, count);
        }
    }
}
