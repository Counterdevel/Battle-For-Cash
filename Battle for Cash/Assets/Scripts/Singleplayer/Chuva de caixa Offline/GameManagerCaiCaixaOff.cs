using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class GameManagerCaiCaixaOff : MonoBehaviour
{

    int allplayers;
    public  List<GameObject> players;
    public  List<GameObject> playerseliminados;
    [Header("UI Elements")]
    public GameObject panel;
    public Text quartoLugar;
    public Text terceiroLugar;
    public Text segundoLugar;
    public Text primeiroLugar;

    public static GameManagerCaiCaixaOff Instance;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }

    void Start()
    {
        players.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        allplayers = players.Count;     
    }
    void Update()
    {
       if(allplayers == 1)
        {
            panel.SetActive(true);                   
        }
    }

    public void ranking(GameObject playeratingindo)
    {  
        playerseliminados.Add(playeratingindo);
        players.Remove(playeratingindo);
        allplayers--;
    
        if(allplayers == 1)
        {
            quartoLugar.text = playerseliminados[0].name;
            playerseliminados[0].GetComponent<PlayerOff>().saldo += 0;
            playerseliminados[0].GetComponent<PlayerOff>().atualizaSaldo();

            terceiroLugar.text = playerseliminados[1].name;
            playerseliminados[1].GetComponent<PlayerOff>().saldo += 5;
            playerseliminados[1].GetComponent<PlayerOff>().atualizaSaldo();

            segundoLugar.text = playerseliminados[2].name;
            playerseliminados[2].GetComponent<PlayerOff>().saldo += 10;
            playerseliminados[2].GetComponent<PlayerOff>().atualizaSaldo();

            primeiroLugar.text = players[0].name;
            players[0].GetComponent<PlayerOff>().saldo += 20;
            players[0].GetComponent<PlayerOff>().atualizaSaldo();

            StartCoroutine(AcabouJogo(5f));
        }
    }
    IEnumerator AcabouJogo(float someParameter)
    {
        yield return new WaitForSeconds(someParameter);
        RandomSceneOff.Instance.LoadNextScene();
    }
}
