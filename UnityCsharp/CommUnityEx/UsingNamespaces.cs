using UnityEngine;
using System.Collections;
using CUE;

public class UsingNamespaces : MonoBehaviour {
    private void Start() {
        Debug.Log("一");

        UsName usName = new UsName();
        CUE.CUEusName2 cueName2 = new CUE.CUEusName2();

        usName.Method();
        cueName2.Method();

        usName = null;
        usName = new UsName();
        usName.Method();

        CUEusName4 cUEusName4 = new CUEusName4();
        cUEusName4.Methed();
    }

    public class CUEusName4 {
        public void Methed() {
            Debug.Log("四");
        }
    }
}

public class UsName {
    public void Method() {
        Debug.Log("三");
    }
}

namespace CUE {
    public class CUEusName2 {
        public void Method() {
            Debug.Log("二");
        }
    }    
}

/*Namespaces
命名空間就像是類的容器
其目的是幫助組織腳本
避免腳本之間發生沖突

例如你可能會
在unity中創建工具
來幫助你開發應用

你可以將工具和實際運用
放在不同的命名空間中
這樣一來 自動補全功能
就不會建議過多不必要的類

到目前為止你編寫的所有腳本
可能一直在使用命名空間

有三種方式
使用來自特定命名空間的類

using 空間 {}

空間.類 變數 = new 空間.類();

在空間裡放你要訪問的類 (不建議
除非你打算把要用的類都丟進去
*/