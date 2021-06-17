using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi52 : MonoBehaviour
{
    public static Mi52 _instance;//單例

    private void Awake()
    {//靜態之後就不可以 new了
        _instance = this;//賦執
    }


    /// <summary>
    /// 靜態類
    /// </summary>
    /// <remarks>其成員是全部都靜態，不可實例</remarks>
    public static class MyStatic_52 {
        static public int a, b, c;
    
        static public int Sum(int x, int y) {
            return x + y;
        }
    }


    void Methed()
    {//部份靜態的使用方式
        Mi52_A mi52_A = new Mi52_A();
        mi52_A.SetValue(100, 200);
        Debug.Log(mi52_A.x);
        Debug.Log(Mi52_A.y);//因為是靜態
        Mi52_A.SetValue(1, 2, 3);//就靜態呀
    }

    class Mi52_A {
        public int x = 10;
        public static int y = 20;
        public void SetValue(int a,int b)
        {
            x = a;
            y = b;
        }

        public static int SetValue(int a,int b,int c)
        {
            return a + b + c;
        }
    }
}