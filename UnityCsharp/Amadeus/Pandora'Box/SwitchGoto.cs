using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGoto : MonoBehaviour
{
    public int a = 0;
    public 點菜啦 _Menu = 點菜啦.待點;

    void Start() {
        Methed01();
        Methed02();
    }

    void Methed01() {
    sw3:
        switch (a)
        {
            case 1:  //可以留空
            case 2:
                Debug.Log("Case 2");
                //continue; (不能使用
                a++;
                if (a == 3)
                    goto sw3;
                break;
            case 3:
                Debug.Log("Case 3");
                break;
            case 4:
                Debug.Log("Case 4");
                goto sw4;
            default:
                Debug.Log("預設路徑");
                break;
        }
    sw4:
        if (a == 4)
            Debug.Log("跳轉到這");
    }

    void Methed02() {

        switch (_Menu)
        {
            case 點菜啦.待點: Methed00();break;
            case 點菜啦.A餐單點:
                Methed01();
                break;
            case 點菜啦.A餐加飲料:
                Methed01(); Methed02();
                break;
            case 點菜啦.B餐單點:
                Methed03();
                break;
            case 點菜啦.B餐加飲料:
                Methed03(); Methed04();
                break;
            case 點菜啦.單點飲料:
                Methed05();
                break;
            default:
                Debug.Log("沒人來就擦桌子");
                break;
        }

        void Methed00() {
            Debug.Log("等待中");
        }

        void Methed01() { Debug.Log("A餐內容"); }
        void Methed02() { Debug.Log("A餐飲料"); }
        void Methed03() { Debug.Log("B餐內容"); }
        void Methed04() { Debug.Log("B餐飲料"); }
        void Methed05() { Debug.Log("單點飲料"); }
    }

    public enum 點菜啦 : byte 
    {
        待點,
        A餐單點,
        A餐加飲料,
        B餐單點,
        B餐加飲料,
        單點飲料
    };
}
