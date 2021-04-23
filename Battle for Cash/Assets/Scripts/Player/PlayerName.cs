using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public Text playerName;
    void Start()
    {
        playerName.text = PhotonNetwork.NickName;
    }
}
