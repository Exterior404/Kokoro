using UnityEngine;
using System.Collections;

public class UsingArrayScript : MonoBehaviour
{
    int[] myIntArrayA = new int[5];
    int[] myIntArrayB = {12, 76, 8, 937, 903};

    public GameObject[] players;

    void Start()
    {
        myIntArrayA[0] = 1;
        myIntArrayA[1] = 2;
        myIntArrayA[2] = 3;
        myIntArrayA[3] = 4;
        myIntArrayA[4] = 5;

        Debug.Log("ArrayA[3]: " + myIntArrayA[3]);
        Debug.Log("ArrayB: " + myIntArrayB);

        players = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " + i + "is named " + players[i].name);
        }
    }
}
/*
 Arrays
儲存同類型數據
數組不是類型 而是
特定類型的變量集合

使用之前要確認使用長度
知道會儲存多少個元素

訪問數組需要變數名 跟索引

關於數組的使用注意
如果使用公開數組 
就能在介面看到 並可設置數值

函數
players = GameObject.FindGameObjectsWithTag("Player");
開始後 可以返回場景上 Tag: Player的所有對象構成數組
並可初始化新的公開數組

另外非常適合使用循環來紀錄
*/