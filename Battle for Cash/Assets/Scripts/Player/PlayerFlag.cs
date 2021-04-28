using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlag : MonoBehaviour
{
    public GameObject bandeiraRoubada;
    public GameObject socket;
    bool flagado = false;

    private void Start()
    {
        bandeiraRoubada = GameObject.FindGameObjectWithTag("Flag");
    }
    public void PickUpFlag(GameObject flag)
    {
        flag.transform.position = socket.transform.position;
        flag.transform.parent = socket.transform;
        flagado = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && flagado == false)
        {
            bandeiraRoubada.transform.position = socket.transform.position;
            bandeiraRoubada.transform.parent = socket.transform;
            flagado = true;
        }
    }

}
