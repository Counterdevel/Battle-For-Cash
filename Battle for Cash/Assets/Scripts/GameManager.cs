using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public Text textovitoria;
    private GameObject vitorioso;

    private void Awake()
    {
        if(!Instance)
        {
            Instance = this;
        }
    }

    public GameObject vitoria;

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
            Debug.Log(nome);
            textovitoria.text = nome + " Venceu!";
            vitoria.SetActive(true);
            
        }
    }
}
