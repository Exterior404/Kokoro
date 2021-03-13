using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = (target.position + new Vector3(0, 0.5f, 0)) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        transform.Translate(0, 0, 3 * Time.deltaTime);
    }
}
/* 
 * lerp
線性插值
在兩個四元數
均勻插值

 * slerp
球形差值
在兩個四元數
曲線上插值

 * Quaternion.identity
歐拉為000 或是無旋轉

四元數是處理旋轉的最佳方式
*/