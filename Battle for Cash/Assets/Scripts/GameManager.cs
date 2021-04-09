using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if(!Instance)
        {
            Instance = this;
        }
    }

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    public GameObject vitoria;

    void Start()
    {
        vitoria.SetActive(false);
    }

    void Update()
    {
        if(player1.activeSelf && !player2.activeSelf && !player3.activeSelf || !player1.activeSelf && player2.activeSelf && !player3.activeSelf || !player1.activeSelf && !player2.activeSelf && player3.activeSelf)
        {
            vitoria.SetActive(true);
        }
    }
}
