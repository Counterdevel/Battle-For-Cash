using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOff: MonoBehaviour
{
    public Text playerName;
    public int saldo = 0;
    void Start()
    {
        //playerName.text;
        //gameObject.name = playerName.text;
        saldo = PlayerPrefs.GetInt("saldoPrefs");
    }

    public void atualizaSaldo()
    {
        PlayerPrefs.SetInt("saldoPrefs", saldo);
    }
}
