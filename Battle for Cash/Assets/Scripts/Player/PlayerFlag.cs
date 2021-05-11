using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlag : MonoBehaviour
{
    public GameObject flag;

    public static bool flagCaptured = false;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Flag"))
        {
            flag.SetActive(true);
            flagCaptured = true;
        }
        if(other.CompareTag("Water"))
        {
            flag.SetActive(false);
            flagCaptured = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ground"))
        {
            CheckpointFlag.drowned = false;
        }
        if(collision.collider.CompareTag("Player") && CheckpointFlag.drowned == false && flagCaptured == false)
        {
            flag.SetActive(true);
        }
    }
}
