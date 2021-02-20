using UnityEngine;
using System.Collections;

public class CardinalDirection : MonoBehaviour
{
    enum DireCtion1 { 北, 東, 南, 西 };
    enum DireCtion2 : short { North, East, South, West };

    enum ErrorCode : ushort
    {
        None = 0,
        Unknown = 1,
        ConnectionLost = 100,
        OutlierReading = 200
    };

    enum ByteEnum : byte
    {
        可,
        不可
    }

    void Start()
    {
        DireCtion1 myDireCtion1;
        myDireCtion1 = DireCtion1.北;

        Debug.Log(ByteEnum.不可);
        Debug.Log(ErrorCode.Unknown);
    }

    DireCtion1 ReverseDirection(DireCtion1 dir)
    {
        if (dir == DireCtion1.北) dir = DireCtion1.南;
        else if (dir == DireCtion1.南) dir = DireCtion1.北;
        else if (dir == DireCtion1.東) dir = DireCtion1.西;
        else if (dir == DireCtion1.西) dir = DireCtion1.東;

        return dir;
    }
}
/*
 * Enum
變數代表含意 要記住它是什麼很麻煩

我們可以創建一組Enum來表示指南針的不同方位
可以在類裡面或類外面創建

注意我們也可以創建 只含Enum的腳本
可以不聲明為Class 而是將它聲明為Enum

我們可以把它放在Class
前提必須是 這個Class需要訪問這個Enum

第一個元素給 1 後面則會接著 2 3 4

    如果需要更改其常量
可以參考第二組 改變類型 為 short
更改的一個主要原因是為了優化
但通常不用理會這個擔心


列舉 (enum)：也有人稱作為 "狀態機"，因為列舉常常被人拿來當作狀態判斷的使用。
enum 所佔的記憶體為 32 位元 (bit)，這是在預設的情況底下。
因為 enum 可以更改型別，共有 byte、sbyte、short、ushort、int、uint、long、ulong。
所以佔據的記憶體容量必須看你是使用什麼型別而定，不過系統預設為 int。
*/
