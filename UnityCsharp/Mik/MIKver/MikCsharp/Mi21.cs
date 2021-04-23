using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi21 : MonoBehaviour
{//取得對象的組件來操作
    Mik.Cat cat;

    void Start() {
        cat = GameObject.Find("MikObject").GetComponent<Mik.Cat>();
        cat.catAge = 123;
    }// 有多層級就 上/中/下
}
