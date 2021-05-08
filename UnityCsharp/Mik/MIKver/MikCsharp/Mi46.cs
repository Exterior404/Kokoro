using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi46 : MonoBehaviour
{//ArrayList
    int[] array_b = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

    int maxValue = 0;
    int row = 0;
    int column = 0;
    int[,] array2d = new int[3, 4] { { 2, 4, 6, 8 }, { 5, 6, 7, 8 }, { 10, 12, 25, 11 } };

    void Start()
    {
        #region 初始化方法
        ArrayList list_a = new ArrayList();
        ArrayList list_b = new ArrayList(array_b);
        //ArrayList list_c = new ArrayList(int x);
        #endregion

        ArrayList list = new ArrayList();
        int a = list.Add(10);
        list.Add(20);
        int b = list.Add(list);

        Debug.Log(a);//0
        Debug.Log(b);//2
        Debug.Log(list[0]);//10
        Debug.Log(list.Count);//3
    }
}
/* Note
    相當於一種高級的動態陣列
位於 System.Collections命名空間下
他可以動態的添加和刪除元素
可以將它看作是擴充了功能的陣列
但它並不等於陣列

普通陣列的容量是固定的
而ArrayList的容量可以根據需要自動擴充

ArrayList提供添加、刪除和插入某一範圍元素的方法
但在陣列中，只能一次獲取或設置一個元素的值

ArrayList 只能是一維陣列

我們可以把它當做是一般的類別來進行處理?
既然是類別 我們就可以通過產生實體物件來進行操作?
 */

/* 常用的方法
Capacity
Add
Insert
Clear
Remove
RemoveAt
RemoveRange
Contains
Sort
 */