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

    private int row;
    private int column;

    public GameObject black_Piece;
    public GameObject white_Piece;

    void Start()
    {
        pv = this.GetComponent<PhotonView>();
    }


    void FixedUpdate()
    {
        //判斷
        if (!pv.IsMine) return;

        //滑鼠 左鍵 0 右1 滾輪2
        if (Input.GetMouseButtonDown(0)) {
            //螢幕座標轉換世界座標
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 offsetPos = mousePos - zeroPos;
            //取得螢幕數值 填入行列
            row = (int)(Mathf.Round(offsetPos.y / cellWidth));
            column = (int)Mathf.Round(offsetPos.x / cellWidth);
            Vector3 piecePos = new Vector3(column * cellWidth, row * cellWidth, zeroPos.z) + zeroPos;

            GameObject newPiece;
            //產生連線的棋
            if (piceColor == PiceColor.黑)
            {
                if(black_Piece!=null)
                newPiece = PhotonNetwork.Instantiate(black_Piece.name, piecePos, black_Piece.transform.rotation);
            }
            else
            {
                if(white_Piece!=null)
                newPiece = PhotonNetwork.Instantiate(white_Piece.name, piecePos, black_Piece.transform.rotation);
            }
        }
    }
}
