using UnityEngine;
using System.Collections;

public class UsingOverload : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();
        myClass.Add(1, 2);
        myClass.Add("Welcom", "Hell");

        Debug.Log(myClass);
    }
}

public class SomeClass
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
}
/*
 通過重載過程
可以為單個方法提供多個定義
這意味著可以使用同一個方法名稱
執行兩項不同的操作
假設你需要一個方法來執行加法
該方法負責將兩個數字相加
AddNumbers

但是 將字符串相加的工作原理不同
你需要一個 AddStrings新方法

這樣雖然可以達到目的
但問題在於現在 
需要記住兩個不同的方法名稱
而它們在本質上執行的是相同的操作

一種更好的方法是重載名為 Add的方法
使其處理數字或字符串

會檢測形式參數 會匹配一樣的
如果沒有則配對 差異最少的 最後則是出包
*/
