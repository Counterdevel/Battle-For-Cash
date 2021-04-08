using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacle;
    public float spawnTimer = 1f;
    public float timer = 0;
    void Update()
    {
        if(timer> spawnTimer)
        {
            int random = Random.Range(0, obstacle.Length);

            GameObject obs = Instantiate(obstacle[random]);
            obs.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(obs, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
