using UnityEngine;
using System.Collections;

public class AwakeAndStart : MonoBehaviour
{
    /*
     這兩個的生命週期只有一次
     因此不能通過禁用和重新啟用
     腳本來重復執行Start函數
         */

    private void Awake()
    {
        /*
         最先進行加載 與初始化之間進行設置任何引用
         */
    }

    private void Start()
    {
        /*
         接在Awake之後! 而且在首次 Update之前!  調用
         但前提是已經啟用此腳本
         */
    }

    /*
     在每個關鍵幀調用一次
     基本上只要需要變化或調整
     都需要使用Update來實現
         */

    private float fixedUpdateTimer;
    private float UpdateTimer;

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate time : " + Time.deltaTime);

        /*
         按固定時間調用
         調用的時間間隔一樣
         使用 Fixed 會立即進行任何必要的物理計算
         因此 任何影響剛體 (即物理對象) 的動作都應該使用 Fixed 來執行
         最好使用 力(Force) 來定義移動
         */
    }

    private void Update()
    {
        Debug.Log("Update time : " + Time.deltaTime);

        /*
         非物理對象的移動 簡單的計時器 輸入檢測
         注意 Update 並不是按固定時間調用的
         如果某一幀比下一幀的處理時間長
         那在 Update調用的時間間隔也就會不同

         */
    }

    private void LateUpdate()
    {

    }

    // VS 的向導建置方式 Ctrl Shift M

}