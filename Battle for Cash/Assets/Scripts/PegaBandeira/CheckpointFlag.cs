using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointFlag : MonoBehaviour
{
    public static bool drowned = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            drowned = true;
        }
    }

    private void Update()
    {
        Flag.Instance.LostFlag(drowned);
    }
}
