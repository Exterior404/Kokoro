using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi23 : MonoBehaviour {

    int buyed;
    float buyed_f;

    void Start() {
        Methed(5, 4, 1000);
        Debug.Log(buyed);
        Methed(5, 4);
        Debug.Log(buyed);

        Methed02(3.5f);
        Debug.Log(buyed_f);
        Debug.Log(buyed);

    }

    private int Methed(int a, int b) {
        int a2 = 60;//芒果
        int b2 = 85;//鳳梨
        buyed = (a * a2) + (b * b2);

        print("總價錢為 = " + buyed);
        return buyed;
    }

    private int Methed(int a, int b, int c) {
        int a2 = 60;//芒果
        int b2 = 85;//鳳梨

        buyed = (c - (a * a2) - (b * b2));

        print("找零數為 = " + buyed);
        return buyed;
    }

    private int Methed(float a, int b) {
        return buyed;
    }

    private int Methed(int a, float b) {
        return buyed;
    }

    private float Methed02(float a) {
        float math;
        float a2 = 4.5f;
        buyed_f = a2 * a;
        buyed = (int)buyed_f;

        math = buyed_f - buyed;

        if (math >= 0.5) {
            buyed++;
        }
        print("計算結果為 = " + buyed_f);
        return buyed_f + buyed;
    }
}