using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mi42 : MonoBehaviour
{
    int[] intArray = new int[] { 2, 3, 5, 7, 11, 13, 17 };
    int[] arrarr = new int[8] { 313, 28, 26, 15, 47, 98, 74, 85 };
    int[,] arraya2D = { { 2, 4, 6, 8 }, { 5, 6, 7, 8 }, { 10, 12, 25, 11 } };

    // Use this for initialization
    void Start() {
        int[,] abc = new int[arraya2D.GetLength(1), arraya2D.GetLength(0)];
    }

    #region 陣列
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

    public void Math04()
    {//不小心做成 二維變成一維
        int[,] array2D = { { 2, 4, 6, 8 }, { 5, 6, 7, 8 }, { 10, 12, 25, 11 } };
        int[] array1D = new int[12];
        int k = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Debug.Log(array2D[i, j] + " i = " + i + " j = " + j);
                array1D[k] = array2D[i, j];
                Debug.Log("KR = " + k + " = " + array1D[k]);
                k++;
            }
        }

        Array.Sort(array1D);
        Debug.Log(array1D[11]);
    }
    #endregion
}