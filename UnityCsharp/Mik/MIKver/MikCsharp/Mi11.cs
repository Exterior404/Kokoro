using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mi11 : MonoBehaviour
{
    private void Start()
    {
        int x, y;
        byte z = 255; //int = 4 byte = 0~255
        float f = 3.141592653f;

        //z = (byte)f;
        //Debug.Log(z);

        x = Convert.ToInt16(f);
        y = Convert.ToInt32(f);
        z = Convert.ToByte(f);

        Debug.Log("F = " + f);
        Debug.Log(string.Format("X={0}, Y={1}, Z={2}", x, y, z));
    }
}
