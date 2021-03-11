using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UExtensionMethods : MonoBehaviour
{
    private void Start()
    {//擴展完之後  就會併在一起了
        transform.ResetTransformation();
    }
}

public static class UExtension
{
    public static void ResetTransformation(this Transform trans)
    {//注意 該方法聲明靜態  還需注意第一個參數+ this + 類
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1f, 1f, 1f);
    }
}
#region 擴展方法
/* Extension Methods
通過擴展方法 可以向類添加功能
而不必創建DriveType或更改原始類型

它非常使用於 需要向類添加功能
但不能編輯類的情況

考慮一下Unity中內置的
Transform類 我們無法 訪問它的原代碼
假設我們想要使用函數輕鬆重置
T坐標類的 位置旋轉縮放

這個函數的理想位置是放在 T座標類
但由於不能直接向這個類進行添加
並且將這個函數添加到派生類 也沒有意義
所以我們將為其建擴展

擴展方法必須放在  非 泛型 靜態擂中

常見做法是專門創建一個類包含它們
擴展方法的用法 和 實例方法類似
它們也聲明為靜態方法
要使用函數成為擴展方法 
而非靜態方法
需要在參數中使用 this 關鍵字

第一個參數將是調用對象
因此當我們調用這個函數時
無需提供這個參數

此外 該第一個參數規定了
這個方法屬於那個類

如果我們想要更多參數
可以在此輸入而不使用 this關鍵字

僅管這個函數聲明具有參數 
但 調用函數時 它將沒有參數
參數隱式地 成為 T座標類的實例
*/
#endregion