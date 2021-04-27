using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandeira : MonoBehaviour
{
    PlayerFlag player;

    private void Update()
    {
        Use();
    }
    public void Use()
    {
        if(player != null)
        {
            player.PickUpFlag(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            this.player = other.GetComponent<PlayerFlag>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.player = null;
    }
}
