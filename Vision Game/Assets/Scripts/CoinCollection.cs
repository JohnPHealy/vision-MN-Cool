using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    [SerializeField] private GameManager manager;
    [SerializeField] private int scoreToGive = 10;
    public float rotationSpeed = 90;

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.AddScore(scoreToGive);
            Destroy(this.gameObject);
        }
    }
}