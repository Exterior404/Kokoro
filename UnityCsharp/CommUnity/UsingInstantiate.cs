using UnityEngine;
using System.Collections;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform barrelEnd;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(projectile, barrelEnd.position, barrelEnd.rotation);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {//附加作用力版
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, projectile.position, projectile.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelEnd.up * 350f);
        }
    }
}

/* 常用於克隆 prefab
 * 一般而言 instantiate 會返回一個名為 Object的類型
 * 如果要 射擊物體 並給它附加作用力
 * 需要將這個類型強制轉換成 Rigidbody
 */