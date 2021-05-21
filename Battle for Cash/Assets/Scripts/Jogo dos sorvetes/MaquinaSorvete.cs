using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaSorvete : MonoBehaviour
{
    public GameObject sorvete;
    public float inicio;
    public float intervalo;

    void Start()
    {
        sorvete = GameObject.FindGameObjectWithTag("Sorvete");
        sorvete.GetComponent<Rigidbody>().AddForce(transform.up * 50);

        InvokeRepeating("JogaSorvete", inicio, intervalo);
    }


    public void JogaSorvete()
    {
        Instantiate(sorvete, transform.position, transform.rotation);
    }
}
