using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toco : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(transform.position.x, 180, transform.position.z);
    }
}
