using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerCaiCaixa : MonoBehaviour
{
    public Text textovitoria;
    public GameObject [] players;
    public int allplayers;
    public static GameManagerCaiCaixa Instance;
    public GameObject panel;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        allplayers = players.Length;
    }
    void Update()
    {
        if(allplayers == 1)
        {
            GameObject vitorioso = GameObject.FindGameObjectWithTag("Player");
            textovitoria.text = vitorioso.GetComponent<PlayerName>().playerName.text + " Venceu!";
            //panel.SetActive(true);
        }
    }

    public void perdeuplayer(int perdeu, string perdedor)
    {
        allplayers -= perdeu;
        print(perdedor);
    }

}
