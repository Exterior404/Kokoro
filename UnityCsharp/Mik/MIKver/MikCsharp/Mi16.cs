using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi16 : MonoBehaviour
{
    int a = 10;
    float b = 10;
    int c = 22;
    float d = 12.5f, e = 0.4f;

    int result;
    bool isBool;

    void Start()
    {
        result = (++a * c) - (int)b--;
        Debug.Log(result);// 21 * 22 -10
        Debug.Log(b);//9  --後綴 比 = 低級

        a = (int)b;
        Debug.Log(a);
        a += (int)b;

        Debug.Log(a);
        isBool = a > b;
        Debug.Log(isBool);
    }
}
