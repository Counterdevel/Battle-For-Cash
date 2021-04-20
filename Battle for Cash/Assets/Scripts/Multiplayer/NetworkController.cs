using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class NetworkController : MonoBehaviourPunCallbacks
{
    [Header("LOGIN")]
    public GameObject loginPn;
    public InputField playerNameInput;
    string tempPlayerName;

    [Header("LOBBY")]
    public GameObject lobbyPn;
    public InputField roomNameInput;
    string tempRoomName;

    [Header("PLAYER")]
    public GameObject playerPUN;
    //public GameObject mainCamera;

    [Header("UI")]
    public GameObject botoes;
    public GameObject logo;
    public GameObject btnVoltar;
    public GameObject SelecaoDePersonagem;
    //public GameObject gameplaylobby;
    public GameObject canvasTelaInicial;
    public GameObject canvasGameplay;

    void Start()
    {
        loginPn.transform.localPosition = new Vector2(700, 0);
        btnVoltar.transform.localPosition = new Vector2(-300, 0);
        lobbyPn.transform.localPosition = new Vector2(0, 500);
        SelecaoDePersonagem.transform.LeanScale(Vector2.zero, 0f);

        tempPlayerName = "User" + Random.Range(1, 20);
        playerNameInput.text = tempPlayerName;

        tempRoomName = "Sala" + Random.Range(1, 5);
    }

    //######## Minhas Funções ##################
    public void Login()
    {
        PhotonNetwork.ConnectUsingSettings();

        if(playerNameInput.text != "")
        {
            PhotonNetwork.NickName = playerNameInput.text;
        }
        else
        {
            PhotonNetwork.NickName = tempPlayerName;
        }       

        loginPn.transform.LeanMoveLocalY(-470, 1f); ;
        lobbyPn.transform.LeanMoveLocalY(0, 1f);
        roomNameInput.text = tempRoomName;
    }

    public void QuickSearch()
    {
        PhotonNetwork.JoinLobby();
    }

    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions() {MaxPlayers=4 };
        PhotonNetwork.JoinOrCreateRoom(roomNameInput.text, roomOptions, TypedLobby.Default);
    }

//############# PUN Callbacks ##################
    public override void OnConnected()
    {
        Debug.LogWarning("############# LOGIN #############");
        Debug.LogWarning("OnConnected");
    }

    public override void OnConnectedToMaster()
    {
        Debug.LogWarning("OnConnectedToMaster");
        Debug.LogWarning("Server: " + PhotonNetwork.CloudRegion);
        Debug.LogWarning("Ping: " + PhotonNetwork.GetPing());
    }

    public override void OnJoinedLobby()
    {
        Debug.LogWarning("############# LOOBY #############");
        Debug.LogWarning("OnJoinedLobby");
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom(tempRoomName);
    }

    public override void OnJoinedRoom()
    {
        Debug.LogWarning("OnJoinedRoom");
        Debug.LogWarning("Nome da Sala: " + PhotonNetwork.CurrentRoom.Name);
        Debug.LogWarning("Nome da Player: " + PhotonNetwork.NickName);
        Debug.LogWarning("Players Conectados: " + PhotonNetwork.CurrentRoom.PlayerCount);

        lobbyPn.transform.localPosition = new Vector2(0, 500);
        //mainCamera.gameObject.SetActive(false);

        //gameplaylobby.gameObject.SetActive(true);

        canvasTelaInicial.SetActive(false);
        canvasGameplay.SetActive(true);

        Vector3 pos = new Vector3(Random.Range(-20, 20), playerPUN.transform.position.y, Random.Range(-20, 20));
        PhotonNetwork.Instantiate(playerPUN.name, pos, playerPUN.transform.rotation, 0);
    }

    public void ClicouJogar()
    {
        SelecaoDePersonagem.gameObject.SetActive(true);
        SelecaoDePersonagem.transform.LeanScale(Vector2.one, 1f).setEaseInOutCubic();
        btnVoltar.transform.LeanMoveLocalX(0, 1f);
        logo.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        botoes.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
    }
    public void ClicouSelecionar()
    {
        loginPn.transform.LeanMoveLocalX(0, 1f);
        SelecaoDePersonagem.gameObject.SetActive(false);
    }
    public void ClicouVoltar()
    {
        loginPn.transform.localPosition = new Vector2(700, 0);
        lobbyPn.transform.localPosition = new Vector2(0, 500);
        logo.transform.LeanScale(Vector2.one, 1f).setEaseInOutElastic();
        botoes.transform.LeanScale(Vector2.one, 1f);
        btnVoltar.transform.LeanMoveLocalX(-300, 1f);
        SelecaoDePersonagem.transform.LeanScale(Vector2.zero, 0f);
        PhotonNetwork.Disconnect();
    }
}
