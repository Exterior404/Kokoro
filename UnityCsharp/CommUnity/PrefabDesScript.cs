using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDesScript : MonoBehaviour
{//射擊物自毀用 默認一秒
    public float DesSec = 1.0f;

    void Start()
    {
        Destroy(gameObject, DesSec);
    }
}