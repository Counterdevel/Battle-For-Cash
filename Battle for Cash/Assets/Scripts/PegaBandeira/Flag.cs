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

    bool flagCaptured = false;

    private void Start()
    {
        socket = GameObject.FindWithTag("Socket");
    }
    [PunRPC]
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameObject.transform.position = socket.transform.position;
            gameObject.transform.rotation = socket.transform.rotation;
            gameObject.transform.parent = socket.transform;
            flagCaptured = true;
        }
    }

    [PunRPC]
    public void RespawnFlag(bool lost)
    {
        if(lost == true)
        {
            gameObject.transform.parent = null;
            PhotonNetwork.Instantiate(gameObject.name, transform.position = new Vector3(Random.Range(-5f, -81.2f), 0f, Random.Range(32f, -56.5f)), transform.rotation);
        }
    }

    public void StolenFlag(bool stolen)
    {
        if(stolen == true && flagCaptured == true)
        {
            gameObject.transform.parent = null;
            gameObject.transform.parent = socket.transform;
        }
    }
}