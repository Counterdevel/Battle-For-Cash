using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;

public class Pause : MonoBehaviour
{
    public Transform box;

    private void Start()
    {
        box.localPosition = new Vector2(0, -500);
    }

    public void CarregaTelaInicial()
    {
        SceneManager.LoadScene(0);
    }
    public void CarregaTelaInicialPhoton()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene(0);
    }
    public void Resume()
    {   
        Time.timeScale = 1f;
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();
    }

    public void Stop()
    {
        box.localPosition = new Vector2(0, 0);
        Time.timeScale = 0f;
    }
}
