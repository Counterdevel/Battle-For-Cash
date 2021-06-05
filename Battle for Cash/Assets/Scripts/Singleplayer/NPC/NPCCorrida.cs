using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCCorrida : MonoBehaviour
{
    NavMeshAgent agent;

    public Vector3 chegada;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(chegada);
    }
}
