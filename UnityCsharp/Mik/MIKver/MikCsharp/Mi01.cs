using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//類型轉換
public class Mi01 : MonoBehaviour {
    float a = 1.2f;
    int b;

    void Start() {
        b = (int)a;
        Debug.Log("a="+a);
        Debug.Log("b="+b);
    }
}