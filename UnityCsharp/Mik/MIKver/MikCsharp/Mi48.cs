using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi48 : MonoBehaviour
{

}

/* Note

在Stack中分配記憶體
在宣告的同時就初始化
以確保資料不為NULL

Stack儲存的數值類型變數
在超出其作用範圍後
所占記憶體會被系統釋放

區域變數 函式的參數與函式的位址等等
由系統管理 必須在編譯時期為已知

這些變數的回收會發生在它從堆疊pop出去的時候
因為個數、大小什麼的都是已知，所以系統知道怎麼進行配置與回收
 */