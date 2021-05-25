using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

namespace NF.Day01 {
    /// <summary>
    /// Photon.Realtime全部回呼函式(CallBack)
    /// </summary>
    public partial class NFPhotonRealtimeCallBack : MonoBehaviourPunCallbacks {
        private void Awake() {
            DontDestroyOnLoad(this); //加載新場景勿 清理此物件
        }
    }
}