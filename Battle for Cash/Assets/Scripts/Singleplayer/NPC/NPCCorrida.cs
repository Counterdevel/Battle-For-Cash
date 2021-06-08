using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCCorrida : MonoBehaviour
{
    NavMeshAgent agent;
    Animator animator;
    Rigidbody rigidbody;

    public Transform waypoint;

    private void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        agent.SetDestination(waypoint.position);
        animator.SetBool("Speed", true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Bullet"))
        {
            agent.enabled = false;
            StartCoroutine("VoltaCorre", 5);
        }
        if (collision.collider.CompareTag("Empurra"))
        {
            agent.enabled = false;
            StartCoroutine("VoltaCorre", 5);
        }
    }

    private IEnumerator VoltaCorre(float time)
    {
        yield return new WaitForSeconds(time);

        agent.enabled = true;
    }

}
