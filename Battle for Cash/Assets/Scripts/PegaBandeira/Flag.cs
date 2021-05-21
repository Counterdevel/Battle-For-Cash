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

    public GameObject GreenSocket;
    public GameObject BlueSocket;
    public GameObject PinkSocket;
    public GameObject BlackSocket;

    private void Start()
    {

    }

    [PunRPC]
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Green"))
        {
            green = true;
        }
        if (other.CompareTag("Blue"))
        {
            blue = true;
        }
        if (other.CompareTag("Pink"))
        {
            pink = true;
        }
        if (other.CompareTag("Black"))
        {
            black = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player") && green == true)
        {
            gameObject.transform.position = GreenSocket.transform.position;
            gameObject.transform.rotation = GreenSocket.transform.rotation;
            gameObject.transform.parent = GreenSocket.transform;
        }
        if (collision.collider.CompareTag("Player") && blue == true)
        {
            gameObject.transform.position = BlueSocket.transform.position;
            gameObject.transform.rotation = BlueSocket.transform.rotation;
            gameObject.transform.parent = BlueSocket.transform;
        }
        if (collision.collider.CompareTag("Player") && pink == true)
        {
            gameObject.transform.position = PinkSocket.transform.position;
            gameObject.transform.rotation = PinkSocket.transform.rotation;
            gameObject.transform.parent = PinkSocket.transform;
        }
        if (collision.collider.CompareTag("Player") && black == true)
        {
            gameObject.transform.position = BlackSocket.transform.position;
            gameObject.transform.rotation = BlackSocket.transform.rotation;
            gameObject.transform.parent = BlackSocket.transform;
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