using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mi11 : MonoBehaviour
{
    public string str = string.Empty;
    private void Start()
    {
        EX01();
        EX02();
        EX03();
        EX04();
    }

    void EX01()
    {
        int x, y;
        byte z = 255; //int = 4 byte = 0~255
        float f = 3.141592653f;

        //z = (byte)f;
        //Debug.Log(z);

        x = Convert.ToInt16(f);
        y = Convert.ToInt32(f);
        z = Convert.ToByte(f);

        Debug.Log("F = " + f);
        Debug.Log(string.Format("X={0}, Y={1}, Z={2}", x, y, z));
    }

    void EX02()
    {//字串轉成數值 本身是數字才可
        string s1 = "1234";
        int v = int.Parse(s1);
        Debug.Log("V = " + v);

        string s2 = "一二三";
        //int j;
        //bool isWork = int.TryParse(s2, out j);
        bool isWork2 = int.TryParse(s2, out int k);
        Debug.Log("isWork = " + isWork2);
    }

    void EX03()
    {
        Debug.Log("Empty = " + str);
    }

    void EX04()
    {
        int a;
        float b;
        string str1 = "12345";
        string str2 = "1.23";
        string str3 = "NF02";

        bool isWork1;
        bool isWork2;
        bool isWork3;
        int v;
        float k;

        a = int.Parse(str1);
        b = float.Parse(str2);
        Debug.Log("a=" + a);
        Debug.Log("b=" + b);
        //布林參考值
        isWork1 = int.TryParse(str1, out v);
        isWork2 = float.TryParse(str2, out k);
        isWork3 = int.TryParse(str3, out v);
        print("第一組數值");
        Debug.Log(isWork1);
        Debug.Log(str1);
        Debug.Log(v);
        print("第二組數值");
        Debug.Log(isWork2);
        Debug.Log(str2);
        Debug.Log(k);
        print("第三組數值");
        Debug.Log(isWork3);
        Debug.Log(str3);
        Debug.Log(v);
    }
}
