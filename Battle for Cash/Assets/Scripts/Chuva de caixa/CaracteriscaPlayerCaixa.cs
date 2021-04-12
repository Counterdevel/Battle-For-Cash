using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracteriscaPlayerCaixa : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Caixa"))
        {
            player.SetActive(false);
        }
    }
}
