using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerCaiCaixa : MonoBehaviour
{
    public Text textovitoria;
    public GameObject vitoria;
    private GameObject vitorioso;

    void Start()
    {
        vitoria.SetActive(false);
    }
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 1)
        {
            vitorioso = GameObject.FindGameObjectWithTag("Player");
            string nome = vitorioso.name;
            textovitoria.text = nome + " Venceu!";
            vitoria.SetActive(true);
        }
    }
}
