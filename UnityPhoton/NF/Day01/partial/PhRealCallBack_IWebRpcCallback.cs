using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;

using ExitGames.Client.Photon; //!! OperationResponse


namespace NF.Day01 {
    public partial class NFPhotonRealtimeCallBack : IWebRpcCallback {
        /// <summary>
        /// WebRpc響應
        /// </summary>
        /// <param name="response">回應結構</param>
        public override void OnWebRpcResponse(OperationResponse response)
        {
            string strresponse = string.Format("OperationCode:{0},\n" +
                "ReturnCode:{1},\n" +
                "DebugMessage:{2},\n" +
                "Parameters:{3},\n" +
                "ToStringFull():{4}",
                response.ReturnCode,
                response.DebugMessage,
                response.Parameters,
                response.ToStringFull()
                );
            Debug.Log(string.Format("Photon.Realtime.IWebRpcCallback - OnWebRpcResponse()<WebRpc響應 - \n" +
                "response:{0}>",
                strresponse));
        }
    }
}