using UnityEngine;
using System.Collections;

public class DestroyBasic : MonoBehaviour
{
    public GameObject other;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {//會刪除對象 (自己)
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {//刪別的對象 需掛載
            Destroy(other);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {//刪除組件的方式 以及延時刪除
            Destroy(GetComponent<Light>(), 6f);
        }
    }
}