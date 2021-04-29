using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Collider playerCheck;
    [SerializeField] private GameManager manager;
    [SerializeField] private int scoreToGive = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            manager.AddScore(scoreToGive);
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            manager.RespawnPlayer();
        }
    }
}
