using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caixa : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            GameManagerCaiCaixa.Instance.ranking(other.gameObject);
        }
        if (other.CompareTag("PurpleNPC"))
        {
            other.gameObject.SetActive(false);
            GameManagerCaiCaixa.Instance.ranking(other.gameObject);
        }
    }
}