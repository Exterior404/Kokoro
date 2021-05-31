using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;

namespace NF.Day01 {
    public class BtnManager : MonoBehaviour
    {
        public static BtnManager inst;

        public GameObject objInit;
        public GameObject objMaster;
        public GameObject objLobby;
        public GameObject objRoom;

        public Button btnConnectUsingSettings;
        public InputField iptNickName;

        public Button btnLobby;

        public Button btnLeaveLobby;
        public Button btnGetCustomRoomList;
        public Button btnCreateRoom;

        public Button btnJoinRandomRoom;
        public Button btnJoinRoom;
        public Button btnJoinOrCreateRoom;
        public Button btnFindFriends;
        public InputField roomName;

        private void Awake()
        {//放入為靜態
            inst = this;
        }

        private void Start()
        {
            objInit.SetActive(true);
            objMaster.SetActive(false);

            btnConnectUsingSettings.onClick.AddListener(delegate () {
                objInit.SetActive(false);
                ConnectUsingSettings(iptNickName.text);
            });

            btnLobby.onClick.AddListener(delegate () {
                objMaster.SetActive(false);
                JoinLobby();
            });

            //- 這三個一起看
            btnLeaveLobby.onClick.AddListener(delegate () {
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

        /// <summary>
        /// 取得名子來建立唯一房主
        /// </summary>
        /// <param name="nickName"></param>
        public void ConnectUsingSettings(string nickName)
        {
            //PhotonNetwork.NickName = nickName;
            //PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.AuthValues = new AuthenticationValues();
            PhotonNetwork.AuthValues.UserId = nickName;
            Debug.Log("nickName: " + nickName);
            PhotonNetwork.ConnectUsingSettings();
        }

        /// <summary>
        /// 進入房間
        /// </summary>
        public void JoinLobby() { PhotonNetwork.JoinLobby(); }

        #region 離開房間

        /// <summary>
        /// 離開房間
        /// </summary>
        public void LeaveLobby() { PhotonNetwork.LeaveLobby(); }

        /// <summary>
        /// 取得房間清單
        /// </summary>
        public void GetCustomRoomList() {
            TypedLobby _typedLobby = new TypedLobby("XD", LobbyType.SqlLobby);
            PhotonNetwork.GetCustomRoomList(_typedLobby, "NF='Welcome'");
        }

        /// <summary>
        /// 創建房間
        /// </summary>
        /// <param name="roomName">房間名稱</param>
        /// <param name="roomOptions">房間屬性</param>
        /// <param name="typedLobby"> 大廳類型</param>
        public void CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby) {
            objLobby.SetActive(false);
            PhotonNetwork.CreateRoom(roomName, roomOptions, typedLobby);
        }
        #endregion

        /// <summary>
        /// 建立朋友名單
        /// </summary>
        public void FindFriends() {
            string[] Friends = new string[] { "A", "B", "C" };
            PhotonNetwork.FindFriends(Friends);
        }

        /// <summary>
        /// 隨機加入房間
        /// </summary>
        public void JoinRandomRoom()
        {
            objLobby.SetActive(false);
            PhotonNetwork.JoinRandomRoom();
        }

        /// <summary>
        /// 加入房間
        /// </summary>
        /// <param name="specifyRoomName">指定房間名稱</param>
        public void JoinRoom(string specifyRoomName) {
            objLobby.SetActive(false);
            PhotonNetwork.JoinRoom(specifyRoomName);
        }

        /// <summary>
        /// 加入或創房間
        /// </summary>
        /// <param name="specifyRoomName">指定房間名稱</param>
        public void JoinOrCreateRoom(string specifyRoomName) {
            objLobby.SetActive(false);
            RoomOptions _roomOptions = new RoomOptions();
            _roomOptions.MaxPlayers = 4;
            _roomOptions.CustomRoomProperties = new ExitGames.Client.Photon.Hashtable() { { "NF", "Welcome" } };
            _roomOptions.CustomRoomPropertiesForLobby = new string[] { "NF" };

            TypedLobby _typedLobby = new TypedLobby("XD", LobbyType.SqlLobby);

            PhotonNetwork.JoinOrCreateRoom(specifyRoomName, _roomOptions, _typedLobby);
        }
    }
}