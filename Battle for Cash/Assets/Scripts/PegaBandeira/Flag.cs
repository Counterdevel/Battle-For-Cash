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

    bool lostFlag = false;


    private void Start()
    {
        transform.position = new Vector3(Random.Range(-5f, -81.2f), 0f, Random.Range(32f, -56.5f));
    }

    private void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            transform.position = new Vector3(Random.Range(-5f, -81.2f), 0f, Random.Range(32f, -56.5f));
        }
    }

    [PunRPC]
    public void LostFlag(bool lost)
    {
        lostFlag = lost;

        if(lostFlag == true)
        {
            gameObject.SetActive(true);
        }
    }
}
