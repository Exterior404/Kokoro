using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGoto : MonoBehaviour
{
    public int a = 0;
    void Start()
    {
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
}
