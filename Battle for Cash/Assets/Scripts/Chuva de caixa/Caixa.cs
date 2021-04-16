using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caixa : MonoBehaviour
{
    public static string eliminado1;
    public static string eliminado2;
    public static string eliminado3;
    int i = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            if(i == 0)
            {
                eliminado1 = other.gameObject.name;
                i++;
            }
            if (i == 1)
            {
                eliminado2 = other.gameObject.name;
                i++;
            }
            if (i == 2)
            {
                eliminado3 = other.gameObject.name;
                i++;
            }

        }
    }


}
