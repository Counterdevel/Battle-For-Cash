using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCCaixa : MonoBehaviour
{
    NavMeshAgent agent;

    float distance;
    Vector3 destination;

    public bool chegou = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        destination = new Vector3(Random.Range(20, -20), 0.06755352f, Random.Range(12, -16));
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
            destination = new Vector3(Random.Range(20, -20), 0.06755352f, Random.Range(12, -16));
            chegou = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Caixa"))
        {
            destination = new Vector3(Random.Range(20, -20), 0.06755352f, Random.Range(12, -16));
        }
        if(collision.collider.CompareTag("Parede"))
        {
            destination = new Vector3(Random.Range(20, -20), 0.06755352f, Random.Range(12, -16));
        }
    }
}
