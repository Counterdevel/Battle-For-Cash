using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinadeChicleteOff : MonoBehaviour
{
    public GameObject prefabBala;
    public float tempoderepetição;
    void Start()
    {
        InvokeRepeating("disparaBala",0, tempoderepetição);
    }
    void disparaBala()
    {
        Instantiate(prefabBala,transform.position, transform.rotation);
    }
}
