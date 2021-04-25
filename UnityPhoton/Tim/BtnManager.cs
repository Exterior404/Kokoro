using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class BtnManager : MonoBehaviour
{
    public static BtnManager inst;

    public GameObject objInit;
    public Button btnConnectUsingSettings;
    public InputField iptNickName;

    public GameObject objMaster;
    public Button btnLobby;

    public GameObject objLobby;
    public Button btnLeaveLobby;
    public Button btnGetCustomRoomList;
    public Button btnCreateRoom;

    public GameObject objRoom;
    public Button btnJoinRandomRoom;
    public Button btnJoinRoom;
    public Button btnJoinOrCreateRoom;
    public Button btnFindFriends;
    public InputField roomName;


    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {
        objInit.SetActive(true);
        objMaster.SetActive(false);

        btnConnectUsingSettings.onClick.AddListener(delegate() {
            objInit.SetActive(false);
            ConnectUsingSettings(iptNickName.text);
        });

        btnLobby.onClick.AddListener(delegate() {
            objMaster.SetActive(false);
            JoinLobby();
        });

        //-
        btnLeaveLobby.onClick.AddListener(delegate() {
            LeaveLobby();
        });

        btnGetCustomRoomList.onClick.AddListener(delegate () {
            GetCustomRoomList();
        });

        btnCreateRoom.onClick.AddListener(delegate () {
            CreateRoom(roomName.text, null, null);
        });

        //

        btnJoinRandomRoom.onClick.AddListener(delegate () {
            JoinRandomRoom();
        });

        btnJoinRoom.onClick.AddListener(delegate () {
            JoinRoom(roomName.text);
        });

        btnJoinOrCreateRoom.onClick.AddListener(delegate () {
            JoinOrCreateRoom(roomName.text);
        });

        btnFindFriends.onClick.AddListener(delegate () {
            FindFriends();
        });
    }

    public void ConnectUsingSettings(string nickName)
    {
        //PhotonNetwork.NickName = nickName;
        //PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.AuthValues = new AuthenticationValues();
        PhotonNetwork.AuthValues.UserId = nickName;
        Debug.Log("nickName: " + nickName);
        PhotonNetwork.ConnectUsingSettings();
    }

    public void JoinLobby()
    {
        PhotonNetwork.JoinLobby();
    }

    //--

    public void LeaveLobby()
    {
        PhotonNetwork.LeaveLobby();
    }

    public void GetCustomRoomList()
    {
        TypedLobby _typedLobby = new TypedLobby("XD", LobbyType.SqlLobby);
        PhotonNetwork.GetCustomRoomList(_typedLobby, "NF='Welcome'");
    }

    public void CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby)
    {
        objLobby.SetActive(false);
        PhotonNetwork.CreateRoom(roomName, roomOptions, typedLobby);
    }

    //*

    public void JoinRandomRoom()
    {
        objLobby.SetActive(false);
        PhotonNetwork.JoinRandomRoom();
    }

    public void JoinRoom(string specifyRoomName)
    {
        objLobby.SetActive(false);
        PhotonNetwork.JoinRoom(specifyRoomName);
    }

    public void JoinOrCreateRoom(string specifyRoomName)
    {
        objLobby.SetActive(false);
        RoomOptions _roomOptions = new RoomOptions();
        _roomOptions.MaxPlayers = 4;
        _roomOptions.CustomRoomProperties = new ExitGames.Client.Photon.Hashtable() {{ "NF", "Welcome"}};
        _roomOptions.CustomRoomPropertiesForLobby = new string[] { "NF"};

        TypedLobby _typedLobby = new TypedLobby("XD", LobbyType.SqlLobby);

        PhotonNetwork.JoinOrCreateRoom(specifyRoomName, _roomOptions, _typedLobby);
    }

    public void FindFriends()
    {
        string[] Friends = new string[] { "A", "B", "C" };
        PhotonNetwork.FindFriends(Friends);
    }
}
