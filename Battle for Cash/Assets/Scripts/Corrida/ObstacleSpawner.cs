using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacle;

    private void Start()
    {
        int random = Random.Range(0, obstacle.Length);
        Instantiate(obstacle[random],this.transform.position, this.transform.rotation);
    }

}
