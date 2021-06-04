using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dis_Pice : MonoBehaviour
{
    public int row;
    public int column;
    public PiceColor piceColor = PiceColor.黑;

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}

public enum PiceColor : byte
{
    黑 = 0,
    白 = 1
}
