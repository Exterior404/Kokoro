using UnityEngine;
using System.Collections;

namespace CUE {
    public partial class CueSpace : MonoBehaviour {

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
}