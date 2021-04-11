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
}
