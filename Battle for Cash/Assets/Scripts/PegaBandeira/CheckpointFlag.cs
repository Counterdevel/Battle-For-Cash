using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointFlag : MonoBehaviour
{
    public Transform checkpoint;
    public GameObject flag;
    GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        flag = GameObject.FindGameObjectWithTag("Flag");
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
}
