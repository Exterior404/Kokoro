using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasucSyntax : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(transform.position.x);
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
/*
 *      Transform座標 角度 比例 
        Debug.Log(transform.position.x);
        Debug.Log(transform.rotation.x);
        Debug.Log(transform.localScale.x);
*/