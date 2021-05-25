using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;

namespace NF.Day01 {
    public partial class NFPhotonRealtimeCallBack : IErrorInfoCallback
    { /* IErrorInfoCallback 錯誤(需事先註冊)??? */
        public override void OnErrorInfo(ErrorInfo errorInfo)
        {//詳見 腳本 ErrorInfo (伺服端所管)
            string strerrorInfo = string.Format(
                "Info:{0},\n" +
                "ToString():{1}",
                errorInfo.Info,
                errorInfo.ToString()
                );
            Debug.Log(string.Format("Photon.Realtime.IErrorInfoCallback - OnErrorInfo()<錯誤訊息 - \n" +
                "errorInfo:{0}>",
                strerrorInfo));
        }
    }
}