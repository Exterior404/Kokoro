using UnityEngine;
using System.Collections;

public class UsingInvokeRepeating : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
        //Invoke的重復使用版 方法 延遲 間隔

        //CancelInvoke("SpawnObject");
        //只想指定可以傳 想暫停的
    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
    }
}