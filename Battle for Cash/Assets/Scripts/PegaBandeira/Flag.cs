using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Flag : MonoBehaviour
{
    public static Flag Instance;

    private void Awake()
    {
        if(!Instance)
        {
            Instance = this;
        }
    }

    GameObject socket;

    private void Start()
    {
        socket = GameObject.FindWithTag("Socket");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameObject.transform.position = socket.transform.position;
            gameObject.transform.rotation = socket.transform.rotation;
            gameObject.transform.parent = socket.transform;
        }
    }

    public void RespawnFlag(bool lost)
    {
        if(lost == true)
        {
            gameObject.transform.parent = null;
            gameObject.transform.position = transform.position = new Vector3(Random.Range(-5f, -81.2f), 0f, Random.Range(32f, -56.5f));
        }
    }
}