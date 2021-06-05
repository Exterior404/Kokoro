using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;//step1    step2
using Photon.Realtime;
public class Dis_NetWork : MonoBehaviourPunCallbacks
{
    public GameObject player;

    void Start()
    {//step3 連線伺服
        PhotonNetwork.ConnectUsingSettings();

    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        print("連線成功");
        //step4 創建或加入房間
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;
        PhotonNetwork.JoinOrCreateRoom("NF Room", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        print("進房成功");
        //step5 創建連線玩家
        if (player == null) return;
        GameObject newPlayer = PhotonNetwork.Instantiate(player.name,Vector3.zero, transform.rotation);//通過名子找
        //初始化設置玩家的一些屬性

        if (PhotonNetwork.IsMasterClient)
        {//房主就先手
            newPlayer.GetComponent<Dis_Player>().piceColor = PiceColor.黑;
        }
        else
        {
            newPlayer.GetComponent<Dis_Player>().piceColor = PiceColor.白;
        }
    }
}
