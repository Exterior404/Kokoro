using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Dis_Player : MonoBehaviour
{
    public Vector3 zeroPos;
    public float cellWidth;
    public PiceColor piceColor = PiceColor.黑;

    private PhotonView pv;
    void Start()
    {
        pv = this.GetComponent<PhotonView>();
    }


    void FixedUpdate()
    {
        //判斷
        if (!pv.IsMine) return;

        //滑鼠 左鍵 0 右1 滾輪2
        if (Input.GetMouseButtonDown(0))
        {

        }
    }
}
