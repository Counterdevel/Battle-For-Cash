using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform checkpoint;
    GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            player.transform.position = checkpoint.position;
            player.transform.rotation = checkpoint.rotation;
        }
    }
    //bandeiraRoubada.transform.position = new Vector3(Random.Range(-43.5f, 30f), -5.62f, Random.Range(-64f, -10.5f));
}