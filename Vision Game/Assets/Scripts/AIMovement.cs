using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class AIMovement : MonoBehaviour
{
    public Transform playerPos;
    private ThirdPersonController myController;
    private NavMeshAgent myAgent;

    void Start()
    {
        myController = GetComponent<ThirdPersonController>();
        myAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        myAgent.SetDestination(playerPos.position);
    }
}
