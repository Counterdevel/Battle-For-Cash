using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandeira : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            this.gameObject.transform.position = other.gameObject.transform.position + transform.up;
          
            Debug.Log("Player me pegou!!");
        }
    }

}
