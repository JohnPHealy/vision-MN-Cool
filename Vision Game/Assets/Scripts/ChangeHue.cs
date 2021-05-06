using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHue : MonoBehaviour
{
    public float speed = 2.5f;
    public Color startColor;
    public Color endColor;
    public bool repeat = false;
    float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (!repeat)
        {
            float t = (Time.time - startTime) * speed;
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        }
        else
        {
            float t = (Mathf.Sin(Time.time - startTime) * speed);
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        }
    }
}
