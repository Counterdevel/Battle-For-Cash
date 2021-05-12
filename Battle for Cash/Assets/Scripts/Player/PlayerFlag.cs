using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerFlag : MonoBehaviour
{
    PhotonView photonView;

    private void Start()
    {
        photonView.GetComponent<PhotonView>();
    }

    private void Update()
    {
        if(!photonView.IsMine)
        {
            return;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Flag.Instance.StolenFlag(true);
        }
    }
}
