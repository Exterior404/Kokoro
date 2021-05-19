using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mi44 : MonoBehaviour
{//一維陣列、二維陣列
    int[] array_a = new int[8] { 13, 28, 31, 47, 53, 60, 77, 23 };
    int[,] array_aa = new int[2, 3] { { 1, 2, 3 }, 
                                      { 4, 5, 6 } };

    int[,,] housees = new int[2, 4, 3] { 
        { {1,2,3 },{4, 5, 6 },{3, 1, 2 },{7, 2, 3 } }        
        ,{ {7, 8, 9 },{8, 9, 0 },{3, 1, 2 },{2, 1, 4 } } 
    };


    int[] intArray = new int[] { 2, 3, 5, 7, 11, 13, 17 };
    int[] arrarr = new int[8] { 313, 28, 26, 15, 47, 98, 74, 85 };

    void Start() {
        //Math01();
        //Math02();
        //Math03();
    }


    public void Math01() {
        int[] array_a = new int[8] { 13, 28, 26, 15, 47, 98, 74, 85 };
        int[] array_b = new int[6];
        int[] array_c = { 1, 2, 3, 4, 5, 6 };

        string[] strArray_a = new string[4] { "A", "B", "C", "D" };

        foreach (var i in array_a) {
            if (i < 30) {
                Debug.Log("i = " + i);
            }
        }

        foreach (var j in strArray_a) {
            if (j == strArray_a[2]) {
                Debug.Log("j = " + j);
            }
        }
    }

    public void Math02() {
        int a = 0;

        Array.Reverse(intArray);
        foreach (var item in intArray) {
            Debug.Log(item + " = Arr");
        }

        Array.Sort(intArray);

        foreach (var item in intArray) {
            Debug.Log("Arr = " + item);
        }

        foreach (var i in intArray) {
            a += i;
        }
        Debug.Log("ArrayAll = " + a);
    }

    public void Math03() {
        Array.Sort(arrarr);
        Debug.Log("mix = " + arrarr[0]);

        Array.Reverse(arrarr);
        Debug.Log("max = " + arrarr[0]);
    }
}