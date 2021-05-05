using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContagemRegressiva : MonoBehaviour
{
    public Text segundosText;
    public Text minutosText;
    public Text pontos;

    public int minutos;
    public float segundos;

    bool fimMinuto = false;
    bool fimSegundos = false;

    private void Start()
    {
        minutosText.enabled = true;
        segundosText.enabled = true;
        pontos.enabled = true;
    }

    private void FixedUpdate()
    {
        segundos -= Time.deltaTime;
        minutosText.text = minutos.ToString("00");
        segundosText.text = segundos.ToString("00");

        if(segundos <= 0)
        {
            minutos--;
            segundos = 59f;
        }
        if(minutos == 0)
        {
            fimMinuto = true;
            if(segundos <= 1)
            {
                segundos = 0;
                fimSegundos = true;
            }
        }
        if(fimMinuto == true && fimSegundos == true && PlayerFlag.flagado == true)
        {
            minutosText.enabled = false;
            segundosText.enabled = false;
            pontos.enabled = false;
            GameManagerFlag.Instance.VenceuJogo(true);
        }
        if (fimMinuto == true && fimSegundos == true && PlayerFlag.flagado == false)
        {
            minutosText.enabled = false;
            segundosText.enabled = false;
            pontos.enabled = false;
            GameManagerFlag.Instance.PerdeuJogo(true);
        }
    }
}
