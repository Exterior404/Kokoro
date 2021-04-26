using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Tim;

public class PhotonRealtimeCallBackManager : MyPhotonRealtimeCallBack
{
    public override void OnConnected()
    {
        base.OnConnected();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        BtnManager.inst.objMaster.SetActive(true);
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        BtnManager.inst.objLobby.SetActive(true);
    }

    //-

    public override void OnLeftLobby()
    {
        base.OnLeftLobby();
        BtnManager.inst.objMaster.SetActive(true);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        BtnManager.inst.objRoom.SetActive(true);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        base.OnCreateRoomFailed(returnCode, message);
        BtnManager.inst.objLobby.SetActive(true);
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        base.OnJoinRandomFailed(returnCode, message);
        BtnManager.inst.objLobby.SetActive(true);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        base.OnJoinRoomFailed(returnCode, message);
        BtnManager.inst.objLobby.SetActive(true);
    }

}
