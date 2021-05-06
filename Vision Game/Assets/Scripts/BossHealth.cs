using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    [SerializeField] private Collider bulletCheck;
    [SerializeField] private GameManager manager;
    public int health = 300;
    [SerializeField] private int scoreToGive = 250;

    private void OnTriggerEnter(Collider bullet)
    {
        if (bullet.gameObject.tag == "Bullet")
        {
            health -= 10;
            if (health <= 200)
            {
                manager.LoseHeart1();
            }
            if(health <= 100)
            {
                manager.LoseHeart2();
            }
            if (health <= 0)
            {
                manager.LoseHeart3();
                manager.AddScore(scoreToGive);
                Death();
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.RespawnPlayer();
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
