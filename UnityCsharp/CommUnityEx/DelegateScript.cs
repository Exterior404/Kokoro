using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CUE
{
    public class DelegateScript : MonoBehaviour
    {
        delegate void MyDelegate(int num);
        MyDelegate myDelegate;

        private void Start()
        {
            myDelegate = PrintNum;
            myDelegate(50);

            myDelegate = DoubleNum;
            myDelegate(50);
        }

        void PrintNum(int num)
        {
            Debug.Log("Print Num: " + num);
        }

        void DoubleNum(int num)
        {
            Debug.Log("Double Num: " + num * 2 );
        }
    }
}
/*
 * Delegates
通過委託 可以在腳本中創建
可靠且復雜的行為
委託可被簡單地視作
函數的容器
可以進行傳遞 或像變量一樣使用
與變量一樣 可以向委託分配值

並且這些值可以在運行時更改

區別在於變量包含數據 而委託包含函數

首先要做的是清除委托模板
這個模板將明確指示可以分配給
委托那些類型的方法

我們用 delegate關鍵字創建委托
後面則是委托的簽名 與函數一樣
委托有返回類型 名稱 和參數列表
*/