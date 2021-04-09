using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi10 : MonoBehaviour
{//類型轉換

    void Start()
    {
        EX01();
        EX02();
    }

    //強制轉換 捨棄後位
    void EX01()
    {
        int i = 5;
        float j = 15.6f;
        i = (int)j;
        Debug.Log("F to I = " + i);
    }

    void EX02()
    {
        float i;
        double j = 3.1415962;
        i = (float)j;
        Debug.Log("D to F = " + i);
    }
}
/* 
 1byte = 8 bit(位元
 1KB = 1024 byte
 1MB = 1024 KB
 1GB = 1024 MB
 1TB = 1024 GB
 1PB = 1024 TB
 1EB = 1024 PB


    1Byte = 8 Bits

1 Kilobyte (KB)     = 1024 Bytes= 2^10 B ~ 10^3     （千）
1 Megabyte (MB)     = 1024 KB   = 2^20 B ~ 10^6     （百萬）
1 Gigabyte (GB)     = 1024 MB   = 2^30 B ~ 10^9     （十億）
1 Terabyte (TB)     = 1024 GB   = 2^40 B ~ 10^12    （兆）
1 Petabyte (PB)     = 1024 TB   = 2^50 B ~ 10^15    （千兆）
1 Exabyte (EB)      = 1024 PB   = 2^60 B ~ 10^18    （百京）
1 Zettabyte (ZB)    = 1024 EB   = 2^70 B ~ 10^21    （十垓ㄍㄞ）
1 Yottabyte (YB)    = 1024 ZB   = 2^80 B ~ 10^24    （秭ㄗˇ）

1 byte = 8bit
boolean = 8bit

char = 16 bit
short = 16 bit

int = 32 bit
float = 32 bit

long = 64 bit
double = 64 bit

decimal = 128 bit
     */
