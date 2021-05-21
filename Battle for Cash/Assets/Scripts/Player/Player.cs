using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player: MonoBehaviour
{
    public Text playerName;
    public int saldo = 0;
    void Start()
    {
        playerName.text = PhotonNetwork.NickName;
        gameObject.name = playerName.text;

        saldo = PlayerPrefs.GetInt("saldoPrefs");
    }

    public void atualizaSaldo()
    {
        PlayerPrefs.SetInt("saldoPrefs", saldo);
    }
}
