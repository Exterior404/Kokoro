using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockAtScript : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        
    }


    void Update()
    {//使其面向目標
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
        //可設置第二個V3 那個方向是向上
        //transform.rotation = Quaternion.LookRotation(relativePos, new Vector3(0, 1, 0));
    }
}
/*
 * Euler angles

Unity要將四元數轉成歐拉角
歐拉角要遵循 萬向節鎖 Called gimbal lock
而萬向節鎖會妨礙增量旋轉 正常工作

幸運的是unity將旋轉存儲為四元數
四元數就不會受到萬節鎖影響

 
其工作原理類似 transform.LockAt
但利用四元數明確設置旋轉
     */
