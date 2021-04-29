using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CaiChão : MonoBehaviour
{
    public List<GameObject> chao;
    public float inicioChuva = 3f;
    public float intervalo = 5f;
    void Start()
    {
        InvokeRepeating("caichão", inicioChuva, intervalo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [PunRPC]
    void caichão()
    {
        int index = Random.Range(0, chao.Count);
        chao[index].GetComponent<MeshRenderer>().material.color = Color.red;
        chao[index].GetComponent<Rigidbody>().isKinematic = false;
    }
}
