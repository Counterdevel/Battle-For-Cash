﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuvaDeCaixa : MonoBehaviour
{
    public GameObject caixa;
    public float tempoQueda = 0f;
    public float tempoIntervalo = 0f;

    public float[] positionsx;
    public float[] positionsz;
    int x;
    int z;

    void Start()
    {
        InvokeRepeating("RespawnCaixa", tempoQueda, tempoIntervalo);
    }

    public void RespawnCaixa()
    {
        x = Random.Range(0, 10);
        z = Random.Range(0, 8);
        Vector3 position = new Vector3(positionsx[x], 35, positionsz[z]);
        Instantiate(caixa, position, transform.rotation);
    }
}