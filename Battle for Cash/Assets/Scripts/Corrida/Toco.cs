using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toco : MonoBehaviour
{
    public float speed = 50;

    //private void OnCollisionEnter(Collision collision)
    //{
      //  collision.transform.parent = this.transform;
    //}
    //private void OnCollisionExit(Collision collision)
    //{
        //collision.transform.parent = null;
    //}
    void Update()
    {
       Rotate();
    }

    void Rotate()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
