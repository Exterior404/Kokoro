using UnityEngine;
using System.Collections;

public class XMLscript : MonoBehaviour
{//XML 的註解用法 以及一些註解使用方式

    //單行註解 https://docs.microsoft.com/zh-tw/dotnet/csharp/codedoc
    public int playerhp = 5;
    public int monster = 3;
    public int damage;
    /* 多行
     * 註解
     */

    #region 可折疊用 非註解
    //代碼照樣運作中
    #endregion

    private void Start()
    {
        XML xML = new XML();
        damage = xML.Method(playerhp, monster);
        Debug.Log(string.Format("受到傷害 {0}", damage));
    }

    /// <summary>
    /// 有使用XML 
    /// </summary>
    /// <remarks>
    /// 擴充註解
    /// </remarks>
    public class XML
    {//其實註解在 編寫中才會看到

        /// <summary>
        /// 血量計算值
        /// </summary>
        /// <param name="a">玩家血量</param>
        /// <param name="b">怪物傷害</param>
        /// <returns name="sum">返回數值</returns>
        /// <exception cref="血比傷害少"></exception>
        public int Method(int a, int b)
        {
            int sum = 0;
            if (a > b)
                sum = a - b;
            else
                sum = a;
            return sum;
        }
    }    
}