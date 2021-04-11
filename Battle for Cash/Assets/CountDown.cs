using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public GameObject startCountdown;
    void Start()
    {
        StartCoroutine("StartDelay");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float timepause = Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup < timepause)
            yield return 0;
        startCountdown.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
