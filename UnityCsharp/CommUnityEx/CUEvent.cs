using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUEvent : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click")) ;
        {
            if (OnClicked != null)
                OnClicked();
        }
    }
}
/*
* Event
事件是一種特殊委託
非常適用於想要提醒其他類
發生了某個事件

你會發現事件函數
與公共多播委託非常相似

事件可視作廣播系統
訂閱方法 跟退訂
這是一種特殊的委託

直接公開變量也是可以
但使用靜態的差別在 
事件具有內在安全性
委託變量則沒有

通過事件 其他類 只能訂不訂
如果改用公開委託變量

其他類可能會調用或是覆蓋委托變量
來執行不合理的操作
如果想要創建一個
包含多個類的動態方法系統
請使用事件變量 而非委託變量
*/