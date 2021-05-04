using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlag : MonoBehaviour
{
    public GameObject bandeiraRoubada;
    public Transform socket;
    public static bool flagado = false;
    bool perdeuBandeira;

    Vector3 position;

    private void Start()
    {
        bandeiraRoubada = GameObject.FindGameObjectWithTag("Flag");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && flagado == false)
        {
            bandeiraRoubada.transform.position = socket.position;
            bandeiraRoubada.transform.parent = socket;
            flagado = true;
            perdeuBandeira = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water") && flagado == true)
        {
            perdeuBandeira = true;
            flagado = false;
        }
    }

    public void PickUpFlag(GameObject flag)
    {
        flag.transform.position = socket.position;
        flag.transform.parent = socket;
        flagado = true;
    }

    public void PerdeuFlag()
    {
        if (perdeuBandeira == true)
        {
            position = new Vector3((Random.Range(-43.5f, 30f)), -5.62f, Random.Range(-64f, -10.5f));
            Instantiate(bandeiraRoubada, position, Quaternion.identity);
        }
    }
}
