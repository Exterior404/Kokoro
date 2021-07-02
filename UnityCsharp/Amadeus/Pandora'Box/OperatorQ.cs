using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorQ : MonoBehaviour
{
    public int testA = 5;
    public int testB = 10;

    delegate void MyDelegate();
    MyDelegate delgatA;
    MyDelegate delgatB;

    void Start()
    {
        Methed01();
        Methed02();
    }

    void Methed01()
    {// ?; 的使用方式
        string strA = testA > testB ? "A大" : "A小";
        print(strA);

        int intA = testA > testB ? 1 : 0;

        //這段委派不能使用 執行會報錯
        //delgatA = intA > 0 ? MethedA : MethedB;
        //delgatA();//空的不能用

        if (intA > 0)
        {//委派不能使用 ?:
            delgatA = MethedA;
            delgatA();
        }
        else
        {
            delgatA = MethedB;
            delgatA();
        }
        // 判斷對錯 ? 選項是 : 選項否
    }

    void Methed02()
    {// ?? 問當前的數值是不是 空的null
        byte? byeA = null;
        int a = byeA ?? -1;
        Debug.Log(string.Format("a = {0}, byeA = {1}", a, byeA));

        byte? byeB = 1;
        int b = byeB ?? 2;
        Debug.Log(string.Format("b = {0}, byeB = {1}", b, byeB));

        //delgatB();//當前沒東西 會出錯
        delgatB = delgatB ?? delgatA;
        delgatB();

        delgatB = delgatB ?? MethedA;
        delgatB();//因非空 所以沒替換

        delgatB = null;
        delgatB = delgatB ?? MethedA;
        delgatB();

        /* ??         
        是就給值
        不是就給空

        屬於當前不確定的用法 難怪會表示黑人問號
         */
    }

    void MethedA()
    {
        print("可以");
    }

    void MethedB()
    {
        Debug.Log("不能");
    }
}
