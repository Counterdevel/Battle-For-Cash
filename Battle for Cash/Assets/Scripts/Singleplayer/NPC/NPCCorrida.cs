using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCCorrida : MonoBehaviour
{
    Rigidbody rigidbody;
    Animator animator;

    public Transform[] waypoint;
    public Transform[] plataforma;

    public float jumpForce;
    public float jumpSpeed;
    public float jumpForcePlataform;
    public float jumpSpeedPLataform;

    public float speed;
    float speedInicial = 15;

    public int index = 0;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Trajeto();
    }

    public void Trajeto()
    {
        float distance = Vector3.Distance(transform.position, waypoint[index].position);

        if (distance < 4.5)
        {
            if (index <= waypoint.Length)
            {
                index++;
            }
        }

        if(rigidbody.velocity.magnitude > 0.1)
        {
            animator.SetFloat("Speed", 0.2f);
        }

        transform.LookAt(waypoint[index].position);
        transform.position = Vector3.MoveTowards(transform.position, waypoint[index].position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Jump"))
        {
            rigidbody.AddForce(transform.up * jumpForce);
            rigidbody.AddForce(transform.forward * jumpSpeed );
        }
        if (other.CompareTag("JumpPlataform")) 
        {
            rigidbody.AddForce(transform.up * jumpForcePlataform);
            rigidbody.AddForce(transform.forward * jumpSpeedPLataform);           

        }
        if(other.CompareTag("Meleca"))
        {
            speed /= 2;
        }
        else
        {
            speed = speedInicial;
        }
        if(other.CompareTag("Water"))
        {
            index = 1;
        }
        if (other.CompareTag("Water2"))
        {
            index = 2;
        }
        if (other.CompareTag("Water3"))
        {
            index = 5;
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

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("JumpPlataform"))
        {
            index++;
        }
    }
}
