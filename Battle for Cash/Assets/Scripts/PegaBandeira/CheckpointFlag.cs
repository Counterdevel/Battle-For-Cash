using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointFlag : MonoBehaviour
{
    bool lostFlag = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            lostFlag = true;
            Flag.Instance.RespawnFlag(lostFlag);
        }
    }
}
