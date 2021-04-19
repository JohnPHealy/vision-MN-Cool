using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAttack : MonoBehaviour
{
    public GameObject bullet;

    public void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}