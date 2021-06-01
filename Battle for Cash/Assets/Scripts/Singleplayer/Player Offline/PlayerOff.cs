using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOff: MonoBehaviour
{
    public Text playerName;
    public int saldo = 0;
    public bool isNPC;
    String Nome;
    void Start()
    {
        if(isNPC == false)
        {
            Nome = PlayerPrefs.GetString("Nome");
            playerName.text = Nome;
            gameObject.name = playerName.text;
        }

        saldo = PlayerPrefs.GetInt("saldoPrefs");
    }

    public void atualizaSaldo()
    {
        PlayerPrefs.SetInt("saldoPrefs", saldo);
    }
}
