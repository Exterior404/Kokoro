using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttrSpinScript : MonoBehaviour
{
    [Range(-100, 100)]
    public int speed = 0;

    [Range(-50, 50)] public int xSpeed = 0;

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
    }
}
/*
 * Attributes
特性
通過特性 你可以在聲明
方法 變量 或類時為其附加信息

要獲取並增強現有代碼 或通過
某種方式更改代碼 這非常有用

特性本身的作用和用途相差很大
Range 讓 public 多了滑條
ExecutelnEditMode 
在類上寫 [ExecutelnEditMode]
未運行時 直接運行
((危險  修改即永久))
*/