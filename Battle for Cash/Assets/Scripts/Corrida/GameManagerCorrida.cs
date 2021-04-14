using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerCorrida : MonoBehaviour
{
    public Text textovitoria;
    public GameObject vitoria;
    private GameObject vitorioso;

    void Start()
    {
        vitoria.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vitorioso = GameObject.FindGameObjectWithTag("Player");
            string nome = vitorioso.name;
            textovitoria.text = nome + " Venceu!";
            vitoria.SetActive(true);
        }

    }
}