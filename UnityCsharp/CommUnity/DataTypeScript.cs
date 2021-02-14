using UnityEngine;
using System.Collections;

public class DataTypeScript : MonoBehaviour
{
    void Start()
    {
        Vector3 currentPosition = transform.position;
        currentPosition = new Vector3(0, 2, 0);

        /*
         * 這個值類型變量 賦值過來的修改 只會影響 這個變量
         * 下方是另一種方法
         */

        Transform tran = transform;
        tran.position = new Vector3(2, 0, 0);
    }
}

/*
DataTypes數據類型

Value 值類型
int float double bool char 
Structs
	Vector3 / Quaternion

值類型變量其實包含 某個值
所有引用類型變量都包含
值存儲位置的存礎地址
因此如果值類型改變
則只會影響特定變量

但如果引用類型改變
所有包含特定存儲地址的變量
都會受到影響

Reference	引用類型
Class
	Transform / GameObject
*/