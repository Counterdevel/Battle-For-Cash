using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCResta : MonoBehaviour
{
    public float speed = 8f;

    int randomIndex;
    bool isGrounded;

    public Transform[] wayPoint;

    private void Start()
    {
        randomIndex = Random.Range(0, wayPoint.Length);
    }

    private void Update()
    {
        MoveRandom();
    }

    public void MoveRandom()
    {
        float distance = Vector3.Distance(transform.position, wayPoint[randomIndex].position);

        if(distance < 0.5f || isGrounded == false)
        {
            randomIndex = Random.Range(0, wayPoint.Length);
            isGrounded = true;
        }

        transform.position = Vector3.MoveTowards(transform.position, wayPoint[randomIndex].position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
