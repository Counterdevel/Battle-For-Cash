using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCCorrida : MonoBehaviour
{
    Rigidbody rigidbody;

    public Transform[] waypoint;

    public float jumpForce;
    public float jumpSpeed;

    public float speed;

    public int index = 0;

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

        if (distance < 3)
        {
            if (index <= waypoint.Length)
            {
                index++;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoint[index].position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Jump"))
        {
            rigidbody.AddForce(transform.up * jumpForce);
            rigidbody.AddForce(transform.forward * jumpSpeed );
        }
        if(other.CompareTag("Water"))
        {
            index = 1;
        }
        if (other.CompareTag("Water2"))
        {
            index = 3;
        }
        if (other.CompareTag("Water3"))
        {
            index = 1;
        }
        if (other.CompareTag("Water4"))
        {
            index = 1;
        }
        if (other.CompareTag("Water5"))
        {
            index = 1;
        }
    }
}
