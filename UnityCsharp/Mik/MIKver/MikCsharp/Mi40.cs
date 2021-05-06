using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi40 : MonoBehaviour
{//Array

    int[] array_a = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
    int[] array_b = new int[6];
    int[] array_c = { 1, 2, 3, 4, 5, 6, 9, 12 };

    float[] f1 = new float[] { 1.5f, 2.3f };
    float[] f2 = { 1.5f, 2.3f, 3.6f };
    float[] f3 = new float[2];

    byte[] array = { };
    
    string[] array_string1 = { "Micky", "TA", "Kevin", "Open" };
    string[] array_string2 = new string[4] { "Micky", "TA", "Kevin", "Open" };
    string[] array_string3 = new string[4];

    private void Start()
    {
        int temp = array_a.Length;

        Debug.Log("此陣列長度是" + temp);

        Ex01();
    }

    void Ex01()
    {
        int[] arr = new int[]{ 1, 2, 3, 4, 5 };

        for (int i = 0; i < 5; i++) {
            Debug.Log(arr[i]);
        }

        foreach (int x in arr) {
            Debug.Log(x);
        }

        #region for foreach
        /*優點
        使用foreach 不需要知道元素數量
        使用for loop 必須要知道元素數量 才能確定範圍*/
        #endregion
    }
}
