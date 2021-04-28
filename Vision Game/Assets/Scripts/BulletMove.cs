using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private GameManager manager;
    [SerializeField] private int scoreToGive = 50;
    private float bulletSpeed = 5;

    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * bulletSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            manager.AddScore(scoreToGive);
        }
    }
}