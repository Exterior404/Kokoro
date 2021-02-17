using UnityEngine;
using System.Collections;

public class UsingInvokeScript : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        Invoke("SpawnObject", 2);                
    }

    void SpawnObject()
    {
        Instantiate(target, new Vector3(0, 3, 0), Quaternion.identity);
    }
}