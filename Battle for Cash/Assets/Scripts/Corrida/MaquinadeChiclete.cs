using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinadeChiclete : MonoBehaviour
{
    public GameObject prefabBala;
    public float bulletSpeed = 100f;
    void Start()
    {
        InvokeRepeating("disparaBala",0, 3f);
    }
 
    void disparaBala()
    {
        Instantiate(prefabBala,transform.position, transform.rotation);
    }
}
