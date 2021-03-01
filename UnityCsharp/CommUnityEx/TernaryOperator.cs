using UnityEngine;
using System.Collections;

public class TernaryOperator : MonoBehaviour
{
    public int health = 10;
    private string message;


    private void Start()
    {
        Methed01(health);
        Methed02(health);
        Methed03(health);
        Methed04(health);
        Debug.Log(message);
    }

    void Methed01(int health) {
        message = health > 0 ? "Player is Alive" : "Player is Dead";
        Debug.Log(message);
    }

    void Methed02(int health) {
        if (health > 0)
            message = "Player is Alive";
        else 
            message = "Player is Dead";
        Debug.Log(message);
    }

    void Methed03(int health) {
        message = health > 0 ? "Player is Alive" : health == 0 ? "Player is  Barely Alive" : "Player is Dead";
        Debug.Log(message);
    }

    void Methed04(int health)
    {
        if (health > 0)
        {
            message = "Player is Alive";
        }
        else
        {
            if (health == 0)
            {
                message = "Player is  Barely Alive";
            }
            else
            {
                message = "Player is Dead";
            }
        }
        Debug.Log(message);
        message = null;
    }
}
/*
三元運算符
用於根據 bool 表達示
在兩個值之間作出選擇

三元運算符可相互嵌套
但如果用於長表達式
這可能會導致代碼 復雜到難以理解
使用三元運算符而非 if語句的
一個基本規則就是
代碼需要簡單 if else 結構
且每種情況只需要一個短表達示
*/