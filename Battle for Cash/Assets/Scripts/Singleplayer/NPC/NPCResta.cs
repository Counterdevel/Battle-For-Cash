using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCResta : MonoBehaviour
{
    Animator animator;

    public float speed = 8f;

    int randomIndex;
    float time = 0;
    bool isGrounded;

    public Transform[] wayPoint;

    private void Start()
    {
        animator = GetComponent<Animator>();

        randomIndex = Random.Range(0, wayPoint.Length);
    }

    private void Update()
    {
        MoveRandom();

        time += 1 * Time.deltaTime;
        if(time >= 2)
        {
            time = 0;
        }

        animator.SetBool("Speed", true);
    }

    public void MoveRandom()
    {
        float distance = Vector3.Distance(transform.position, wayPoint[randomIndex].position);

        if(distance < 5f || isGrounded == false || time == 2)
        {
            randomIndex = Random.Range(0, wayPoint.Length);
        }

        Quaternion rotate = Quaternion.LookRotation(wayPoint[randomIndex].position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotate, 50f * Time.deltaTime);

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
