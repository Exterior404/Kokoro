using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach_Co : MonoBehaviour
{
    int reInt;

    void Start()
    {
        ForEx1();
        ForEx2();
        ForEx3();
        ForEx4();
    }

    // for( 變量; 條件; 變化值) { 劇本內容 }

    void ForEx1()
    {
        int a = 0;

        for (int i = 0; i < 5; i++)
        {
            a = a + 1;
            Debug.Log(string.Format("a = {0}",a));
        }
    }

    void ForEx2()
    {
        int b = 0;

        int i;
        for (i = 0; i < 5; )
        {
            b++;
            Debug.Log(string.Format("b = {0}", b));
            i++;
        }
    }

    void ForEx3()
    {
        int c = 0;

        int i = 0;
        for(; i < 5;)
        {
            c++;
            Debug.Log(string.Format("c = {0}", c));
            i = i + 1;        
        }
    }

    void ForEx4()
    {
        int d = 0;

        int i = 0;
    Ex4:        
        if (i < 5)
        {
            d++;
            Debug.Log(string.Format("d = {0}", d));
            i = i + 1;
            goto Ex4;
        }
        //else { 選擇性留著 }
    }

    public IEnumerator ForEx5()
    {
        yield return null;
        int e = 0;

        int i = 0;
    Ex5:
        if (i < 5)
        {
            e++;
            Debug.Log(string.Format("e = {0}", e));
            i = i + 1;
            goto Ex5;//依情況在小範圍內使用 goto並沒什麼大礙
        }
    }

    int ForEx6(int for_i, int index, int number ,object box)
    {
        // 覺得Foreach 太陽春，就造一個吧

        return reInt;
    }


    /*
    foreach 被講說 太吃效能
    而且只要使用就整個資料 全查一遍的固定語法
    其名為 for + each 意指為 
    每個迴圈都檢查一次 陣列(別名數組)裡面的成員
    而 for 自身最低限度的 就一個條件
     
    無倫 for裡面如何改 都跳脫不了 for的框架局限
    那為何我不把 for 整個改掉 來強化 foreach ?

    (資料分類?)(轉換列表?)(配合演算法?)(客制化協程?)
     */
}