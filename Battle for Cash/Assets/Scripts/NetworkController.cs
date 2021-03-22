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
    public GameObject mainCamera;

    [Header("UI")]
    public GameObject paineis;
    public GameObject botoes;
    public GameObject imagens;
    public GameObject btnVoltar;


    void Start()
    {
        loginPn.transform.localScale = Vector2.zero;
        btnVoltar.transform.localScale = Vector2.zero;

        tempPlayerName = "User" + Random.Range(1, 20);
        playerNameInput.text = tempPlayerName;

        tempRoomName = "Pato" + Random.Range(1, 5);
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

        loginPn.gameObject.SetActive(false);
        lobbyPn.gameObject.SetActive(true);
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

        loginPn.gameObject.SetActive(false);
        lobbyPn.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(false);

        PhotonNetwork.Instantiate(playerPUN.name, playerPUN.transform.position, playerPUN.transform.rotation, 0);
    }

    public void ClicouJogar()
    {
        loginPn.gameObject.SetActive(true);
        loginPn.transform.LeanScale(Vector2.one, 0.8f);
        imagens.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        paineis.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        botoes.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        btnVoltar.gameObject.SetActive(true);
        btnVoltar.transform.LeanScale(Vector2.one, 0.8f);
    }
    public void ClicouVoltar()
    {
        loginPn.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        lobbyPn.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        imagens.transform.LeanScale(Vector2.one, 0.8f);
        paineis.transform.LeanScale(Vector2.one, 0.8f);
        botoes.transform.LeanScale(Vector2.one, 0.8f);
        btnVoltar.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
    }
}
