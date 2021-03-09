using UnityEngine;
using System.Collections;
using CUE;

namespace CUE {
    public partial class CueSpace : MonoBehaviour {
        private void Start() {
            CUE.Orc orc = new Orc();
            CUE.Enemy enemy = new Enemy();
            CUE.Humanoid humanoid = new Humanoid();

            orc.Yell();
            enemy.Yell();
            humanoid.Yell();
        }
    }
    #region 成員隱藏
    //public class Humanoid
    //{
    //    void Yell()
    //    {
    //        // Play audio clip.
    //        // Move arms.
    //    }
    //}

    //public class Enemy : Humanoid
    //{
    //    new void Yell()
    //    {
    //        //Change material color to yellow.
    //    }
    //}

    //public class Orc : Enemy
    //{
    //    new void Yell()
    //    {
    //        //Set nav mesh to Northern Shetland Isle.
    //    }
    //}
    #endregion
    #region 成員隱藏Note
    /*Merber Hiding
成員隱藏
通過繼承 父類成員
在子類中可自動可用或繼承到子類中
在子類中重新創建
即重新聲明父類成員的過程
被稱為成員隱藏

隱藏成員使用關鍵字
new的方式略有不同
new int OOO = 5;

一般情況下 這不會影響
以這種方式聲明的成員來使用

但是當子類 向上轉型為父類
和使用的成員時
它將是來自父類的成員
就算是 實做例為子類
想像一個繼承層次結構
Humanoid>Enemy<Orc
*/
    #endregion

    public class Humanoid {
        public virtual void Yell() {
            Debug.Log("Humanoid");
        }
    }

    public class Enemy : CUE.Humanoid {
        public override void Yell() {
            base.Yell();
            Debug.Log("Enemy");
        }
    }

    public class Orc : CUE.Enemy {
        public override void Yell() {
            base.Yell();
            Debug.Log("Orc");
        }
    }
    #region 覆寫
/*
 * Overriding
覆寫是指 更改子類中的父類方法
結果是 當我們調用方法時
將調用最新版本的方法 或最新覆蓋的版本

使用繼承層次結構時
我們通常使用與基類 略微不同的函數版本
只需在子類中重新創建方法
並根據需要編寫代碼即可

可使用 virtual 和 override 關鍵字
這些字位於方法的返回類型之前

聲明為 virtual 可被任何子類覆蓋
覆蓋的一種更有趣的用法是
如果讓每個子類為方法添加特定功能
同時不失去父類提供的原始功能
為此 需要使用 base關鍵字
*/
    #endregion
}
 