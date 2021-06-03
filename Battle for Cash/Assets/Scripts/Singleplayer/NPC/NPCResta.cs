using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCResta : MonoBehaviour
{
    public GameObject pontoInicial;

    public float speed = 1;  
    private float timer = 0f;

    public static bool borda = false;

    private void Start()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
    }

    void Update()
    {
        if (timer <= 0)
        {
            timer = 2f;

            transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
        }
        timer -= Time.deltaTime;

        transform.Translate(transform.forward * speed * Time.deltaTime);

        if(borda == true)
        {
            transform.eulerAngles = new Vector3(0, pontoInicial.transform.position.x, 0);
            borda = false;
        }
    }
}
