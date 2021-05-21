using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinadeChiclete : MonoBehaviour
{
    public GameObject prefabBala;
    public float tempoderepetição = 2f;
    void Start()
    {
        InvokeRepeating("disparaBala",0, tempoderepetição);
    }
 
    void disparaBala()
    {
        Instantiate(prefabBala,transform.position, transform.rotation);
    }
}
