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
        
        destination = new Vector3(Random.Range(-33.9f, 34), 9.58f, Random.Range(23, -19));
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
            destination = new Vector3(Random.Range(-33.9f, 34), 9.58f, Random.Range(23, -19));
            chegou = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Parede"))
        {
            destination = new Vector3(Random.Range(-33.9f, 34), 9.58f, Random.Range(23, -19));
        }
    }
}
