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
        transform.position += Vector3.forward * Time.deltaTime * bulletSpeed;
    }
}