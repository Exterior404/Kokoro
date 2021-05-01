using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormatTest : MonoBehaviour {
    void Start() {
        string a = "A", b = "B";
        Debug.Log(string.Format("a = {0} b = {1}", a, b));
        Debug.Log(string.Format("a = {0} b = {1}\n",a ,b) + string.Format("a = {0} b = {1}", a, b));

        a = "測試用"; b = "文本"; string c = "範例";
        Debug.Log(string.Format("{0}{1}{2}\n", a, b,c)
            + string.Format("{2}{1}{0}\n", a, b, c)
            + string.Format("{0}{2}{1}\n", a, b, c)
            );
    }
}