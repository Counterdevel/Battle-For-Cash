using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class GameManagerCaiCaixa : MonoBehaviour
{
    
    public  List<GameObject> players;
    public  List<GameObject> playerseliminados;
    int allplayers;
    [Header("UI Elements")]
    public Text textovitoria;
    public GameObject panel;
    public Text quartoLugar;
    public Text terceiroLugar;
    public Text segundoLugar;
    public Text primeiroLugar;

    public static GameManagerCaiCaixa Instance;

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
            //textovitoria.text = vitorioso.GetComponent<PlayerName>().playerName.text + " Venceu!";
            panel.SetActive(true);
        }
    }

    public void perdeuplayer(GameObject playeratingindo)
    {
        
        playerseliminados.Add(playeratingindo);
        players.Remove(playeratingindo);
        allplayers--;
    
        if(allplayers == 1)
        {
            quartoLugar.text = playerseliminados[0].name;
            playerseliminados[0].GetComponent<Player>().saldo += 0;
            playerseliminados[0].GetComponent<Player>().atualizaSaldo();

            terceiroLugar.text = playerseliminados[1].name;
            playerseliminados[1].GetComponent<Player>().saldo += 5;
            playerseliminados[1].GetComponent<Player>().atualizaSaldo();

            segundoLugar.text = playerseliminados[2].name;
            playerseliminados[2].GetComponent<Player>().saldo += 10;
            playerseliminados[2].GetComponent<Player>().atualizaSaldo();

            primeiroLugar.text = players[0].name;
            players[0].GetComponent<Player>().saldo += 20;
            players[0].GetComponent<Player>().atualizaSaldo();
        }
    }

}
