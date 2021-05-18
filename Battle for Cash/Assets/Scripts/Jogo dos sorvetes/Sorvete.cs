using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorvete : MonoBehaviour
{
    GameObject socket;

    void Start()
    {
        socket = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            gameObject.transform.position = socket.transform.position;
            gameObject.transform.rotation = socket.transform.rotation;
            gameObject.transform.parent = socket.transform;
        }
    }
}
