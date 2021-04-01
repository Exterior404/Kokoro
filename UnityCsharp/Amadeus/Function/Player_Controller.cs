using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void NoteUpdate()
    {
        #region 光標事件
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("LB");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("RB");
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("MB");
        }
        #endregion
        #region 鍵盤事件
        if (Input.GetKeyDown("tab"))
        {
            Debug.Log("tab");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("空白鍵");
        }
        #endregion
    }
}
