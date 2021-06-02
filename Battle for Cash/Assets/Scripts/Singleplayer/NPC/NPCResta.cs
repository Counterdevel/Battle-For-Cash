using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCResta : MonoBehaviour
{
    NavMeshAgent agent;

    float distance;
    Vector3 destination;

    public bool chegou = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        destination = new Vector3(Random.Range(-34, 34), 10, Random.Range(24, -19));
    }

    private void Update()
    {
        Run();
    }

    public void Run()
    {
        agent.SetDestination(destination);
        distance = Vector3.Distance(destination, transform.position);

        if (distance < 5f)
        {
            destination = new Vector3(Random.Range(-34, 34), 10, Random.Range(24, -19));
            chegou = true;
        }
    }
}
