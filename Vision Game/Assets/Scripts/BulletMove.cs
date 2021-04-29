using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private float bulletSpeed = 5;

    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    void Update()
    {
        transform.Translate(0, 0, bulletSpeed * Time.deltaTime);
    }
}