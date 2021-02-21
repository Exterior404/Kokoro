using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public static class ThisCodeTip
{
    public static void DoSomething(this GameObject obj)
    {//製做一個公開的靜態 this會指向這份文件
        Debug.Log("使用了擴展文件");
    }

    public static string ToHex(this Color color)
    {//將RGB代碼 轉換成 Html的Hex碼 就是 #FFFFFF
        return ColorUtility.ToHtmlStringRGB(color);
    }
}
