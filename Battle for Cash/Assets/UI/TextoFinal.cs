using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoFinal : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text.text = "Você ganhou R$" + PlayerPrefs.GetInt("saldoPrefs")+",00" + " nesta partida!";
    }
}
