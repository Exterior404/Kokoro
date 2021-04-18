using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi17 : MonoBehaviour
{//三元表達式
    bool isTrue;
    int result;
    int x = 100, y = 200;

    void Start()
    {
        result = x > y ? x : y;

        Debug.Log(result);//200
    }
}