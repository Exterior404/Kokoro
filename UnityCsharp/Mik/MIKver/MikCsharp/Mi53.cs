using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi53 : MonoBehaviour
{
    public int[] arrayInt = new int[7];
    public string[] arrayStr = new string[7];
    void Start() {
        Dictionary<int, string> myDic = new Dictionary<int, string>();

        //添加鍵值
        myDic.Add(0, "Night");
        myDic.Add(1, "NF");
        myDic.Add(3, "Feather");
        myDic.Add(5, "LF");
        myDic.Add(7, "NightFeather");
        myDic.Add(13, "Light");
        myDic.Add(30, "LightFeather");

        //移除鍵值
        myDic.Remove(5);

        //清空字典
        //myDic.Clear();

        //取得字典中的個數
        int count = myDic.Count;
        Debug.Log(count);

        //檢查字典中 是否包含指定Key
        bool b = myDic.ContainsKey(2);
        Debug.Log(b);

        //檢查字典中 是否包含指定Value
        bool c = myDic.ContainsValue("TA");
        Debug.Log(c);

        //嘗試取指定的Key 所對應的Values
        string str;
        myDic.TryGetValue(5, out str);
        Debug.Log(str);

        //特別的方式 示範轉為一維數組
        Dictionary<int, string>.KeyCollection keyCollection = myDic.Keys;
        Dictionary<int, string>.ValueCollection valueCollection = myDic.Values;

        //數組大小先決定好 CopyTo 目標 與 原本的第幾個開始復製
        keyCollection.CopyTo(arrayInt, 0);
        Debug.Log(arrayInt.Length);

        foreach (var item in keyCollection)
        {
            Debug.Log(item);
        }

        valueCollection.CopyTo(arrayStr, 0);
        Debug.Log(arrayStr.Length);

        foreach (var item in valueCollection)
        {
            Debug.Log(item);
        }

        for (int i = 0; i < arrayStr.Length; i++)
        {
            Debug.Log(arrayStr[i]);
        }

    }
}