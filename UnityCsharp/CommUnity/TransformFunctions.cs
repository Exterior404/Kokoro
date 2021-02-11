using UnityEngine;
using System.Collections;

public class TransformFunctions : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    void Start()
    {

    }


    void FixedUpdate()
    {
        //transform.Translate(new Vector3(0, 0, 1)); //平移
        #region 移動旋轉
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        #endregion

        /*
         這些是使用局部軸 並非世界軸 是使用遊戲對象的
         如果想用碰撞體移動某個對象 也就是將會產生物理作用的物體
         則不應該使用 Translate Rotate
         而是應該考慮使用 Physics
         */
    }
}
