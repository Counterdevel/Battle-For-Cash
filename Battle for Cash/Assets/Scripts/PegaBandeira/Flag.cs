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
    bool green = false;
    bool blue = false;
    bool pink = false;
    bool black = false;

    public GameObject greenSocket;
    public GameObject blueSocket;
    public GameObject pinkSocket;
    public GameObject blackSocket;

    private void Start()
    {

    }

    [PunRPC]
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Green"))
        {
            green = true;
            gameObject.transform.position = greenSocket.transform.position;
            gameObject.transform.rotation = greenSocket.transform.rotation;
            gameObject.transform.parent = greenSocket.transform;
        }
        if (other.CompareTag("Blue"))
        {
            blue = true;
            gameObject.transform.position = blueSocket.transform.position;
            gameObject.transform.rotation = blueSocket.transform.rotation;
            gameObject.transform.parent = blueSocket.transform;
        }
        if (other.CompareTag("Pink"))
        {
            pink = true;
            gameObject.transform.position = pinkSocket.transform.position;
            gameObject.transform.rotation = pinkSocket.transform.rotation;
            gameObject.transform.parent = pinkSocket.transform;
        }
        if (other.CompareTag("Black"))
        {
            black = true;
            gameObject.transform.position = blackSocket.transform.position;
            gameObject.transform.rotation = blackSocket.transform.rotation;
            gameObject.transform.parent = blackSocket.transform;
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

}