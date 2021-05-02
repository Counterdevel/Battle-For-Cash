﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaUmManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}