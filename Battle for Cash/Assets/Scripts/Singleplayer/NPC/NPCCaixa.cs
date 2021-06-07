using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCCaixa : MonoBehaviour
{
    public Transform[] waypoints;

    public float speed;

    int index;

    private void Start()
    {
        index = Random.Range(0, 88);
    }

    private void Update()
    {
        MoveRandom();
    }

    public void MoveRandom()
    {
        float distance = Vector3.Distance(transform.position, waypoints[index].position);

        if(distance < 1)
        {
            index = Random.Range(0, 88);
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[index].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Caixa") || collision.collider.CompareTag("Parede"))
        {
            index = Random.Range(0, 88);
        }
    }
}
