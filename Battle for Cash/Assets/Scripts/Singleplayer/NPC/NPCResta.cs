using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCResta : MonoBehaviour
{
    public float speed = 1;  
    private float timer = 0f;      
    private Vector3 direcao;

    private void Start()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
        {
            if(hit.transform.name == "parede")
            {
                transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
            }
        }

        if (timer <= 0)
        {
            timer = 2f;

            transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
        }
        timer -= Time.deltaTime;

        transform.Translate(transform.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Parede"))
        {
            Debug.Log("paredou");

            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
