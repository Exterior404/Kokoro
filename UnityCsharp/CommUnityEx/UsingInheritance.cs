using UnityEngine;
using System.Collections;

public class UsingInheritance : MonoBehaviour
{
    void Start()
    {

    }    
}

/* 繼承之下的新規則
 * public 父類使用連子類也會可訪問
 * private 將存在於子類 但不可訪問
 * protected 混和上方兩種
 * 子可用父的兵器使用
 * 
 * 
 * 構造函數只有唯一並不共享
 */

namespace ShopSpace
{
    class PrivateShop {
        public PrivateShop()
        {
            Debug.Log("Private 建構方法");
        }
    }

    public class PublicShop {
        public PublicShop()
        {
            Debug.Log("Public 建構方法");
        }
    }

    abstract public partial class AbsShop
    {//測試用 尚無用途

    }        
}

namespace CUE
{//測試寫法空間
    class Apple : ShopSpace.PublicShop
    {
        ShopSpace.PublicShop shopA = new ShopSpace.PublicShop();

    }
}