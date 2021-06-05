using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCCorrida : MonoBehaviour
{
    Rigidbody rigidbody;

    public Transform[] waypoint;

    public float jumpForce;
    public float speed;

    int index = 0;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Trajeto();
    }

    public void Trajeto()
    {
        float distance = Vector3.Distance(transform.position, waypoint[index].position);

        if(distance < 0.5f)
        {
            index++;
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoint[index].position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Jump"))
        {
            rigidbody.AddForce(transform.up * jumpForce);
        }
    }
}
