using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mi12 : MonoBehaviour
{//強制轉型

    public int j1 = 90;
    private int j2 = 20;
    string strName = "12345";
    string strName2 = "1.23";
    int ad = 1000000000;
    byte ff = 255;
    Int16 nn = 12345;
    Int32 hh = 1234567890;
    Int64 kk = 1234567890123456789;
    int v;
    float k;
    string str1 = "2.8";

    void Start()
    {
        //v = int.Parse(strName);
        bool isWork = int.TryParse(strName, out v);
        Debug.Log(string.Format("isWork = {0}, strName = {1}, v = {2}", isWork, strName, v));

        bool isWork2 = float.TryParse(strName2, out k);
        Debug.Log(isWork2);
        Debug.Log(k);
        Debug.Log(strName2);


        int bb = Int16.Parse(strName);
        Debug.Log("bb = " + bb);
    }
}
