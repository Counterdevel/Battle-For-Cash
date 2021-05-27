using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerFlag : MonoBehaviour
{
    public static GameManagerFlag Instance;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }

    public Text derrota;
    public Text derrotaBack;
    public Text vitoria;
    public Text vitoriaBack;
    bool venceu = false;
    bool perdeu = false;

    public void VenceuJogo(bool value)
    {
        venceu = value;
        if(venceu == true)
        {
            vitoria.enabled = true;
            vitoriaBack.enabled = true;
        }
    }
    public void PerdeuJogo(bool value)
    {
        perdeu = value;
        if (perdeu == true)
        {
            derrota.enabled = true;
            derrotaBack.enabled = true;
        }
    }
}
