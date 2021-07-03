using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidSc : MonoBehaviour
{
    public int x = 0;

    void Start() {
        MethedV();
        MethedI(3);
        MethedVX();
        MethedVX2();
    }

    void MethedV() {
        Debug.Log("Welcome Hell");
    }

    int MethedI(int a) {
        x = a;
        Debug.Log("x = " + x);
        return x;
    }

    void MethedVX() {
        Debug.Log("跳船下去");
        return;
        Debug.Log("VX");
    }

    void MethedVX2() {
        if (x != 3) return;//符合先彈出

        Debug.Log("是參就繼續下去?");

        if (x == 3)
            Debug.Log("是3就有這句");
        return;//此處已彈出

        Debug.Log("這句不執行");
        return;
    }
}