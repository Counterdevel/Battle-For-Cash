using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneOff : MonoBehaviour
{
    static List<int> availableScenes =new List<int> { 4, 5, 6};
    bool segundarodada = false;

    public void LoadNextScene()
    {
        int index = Random.Range(0, availableScenes.Count);
        int theSceneIndex = availableScenes[index];
        availableScenes.Remove(theSceneIndex);
        SceneManager.LoadScene(theSceneIndex);
        if (availableScenes.Count == 0)
        {
            availableScenes = new List<int> { 4, 5, 6 };
            Debug.Log("Acabou as fases, recomeçando");
            segundarodada = true;
        }
        if (availableScenes.Count == 0 && segundarodada == true)
        {
            SceneManager.LoadScene(7);
        }
    }
}
