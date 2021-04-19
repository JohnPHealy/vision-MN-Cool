using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private UnityEvent timerEnd;
    [SerializeField] private float timeDuration = 1.0f;

    void Start()
    {
        StartCoroutine("SetTimer");
    }

    IEnumerable SetTimer()
    {
        yield return new WaitForSeconds(timeDuration);
    }
}
