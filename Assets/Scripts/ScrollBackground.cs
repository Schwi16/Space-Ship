using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float speed = -2f;
    public float lowerYvalue = -20f;
    public float upperYvalue = 40;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
        if (transform.position.y <= lowerYvalue)
        {
            transform.Translate(0f, upperYvalue, 0f);
        }
    }
}
