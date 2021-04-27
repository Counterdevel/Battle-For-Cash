using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlag : MonoBehaviour
{
    public GameObject bandeiraRoubada;
    public GameObject socket;
    bool bandeirado = false;

    public void PickUpFlag(GameObject flag)
    {
        flag.transform.position = socket.transform.position;
        flag.transform.parent = socket.transform;
        bandeirado = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && bandeirado == false)
        {
            bandeiraRoubada.transform.position = socket.transform.position;
            bandeiraRoubada.transform.parent = socket.transform;
        }
    }

    public void Ladrao(bool flagado)
    {

    }
}
