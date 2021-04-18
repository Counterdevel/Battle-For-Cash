using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelect : MonoBehaviour
{
    public int playerSelected = 0;
    public GameObject PlayerList;
    public Image playerIconCanvas;

    PhotonView photonView;
    public GameObject myPlayerCanvas;
    private void Start()
    {
        photonView = this.GetComponent<PhotonView>();
        if (!photonView.IsMine)
        {
            myPlayerCanvas.gameObject.SetActive(false);
        }
        playerSelected = PlayerPrefs.GetInt("HERO");
        SwitchPlayer();
    }
    public void SwitchPlayer()
    {
        photonView.RPC("SwitchPlayerRPC", RpcTarget.AllBuffered);
    }
    [PunRPC]
    public void SwitchPlayerRPC()
    {
        int i = 0;

        foreach (Transform item in PlayerList.transform)
        {
            if (i == playerSelected)
            {
                item.gameObject.SetActive(true);
                if (item.gameObject.GetComponent<PlayerConfig>())
                {
                    playerIconCanvas.sprite = item.gameObject.GetComponent<PlayerConfig>().playerIcon;
                }
            }
            else
            {
                item.gameObject.SetActive(false);
            }
            i++;
        }

    }
}
