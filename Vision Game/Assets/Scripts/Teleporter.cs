using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject player;
    public Transform teleportDestination;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == player.gameObject.name)
        {
            player.GetComponent<CharacterController>().transform.position = teleportDestination.position;
            if (player.GetComponent<Rigidbody>() != null) player.GetComponent<Rigidbody>().Sleep();
        }
    }
}