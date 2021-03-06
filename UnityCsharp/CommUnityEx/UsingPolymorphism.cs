using UnityEngine;
using System.Collections;

public class UsingPolymorphism : MonoBehaviour
{//此例有誤
    private void Start()
    {
        //ParentClass myClass = new ChildClass();
        //myClass.ParentMethod();
        //ChildClass myChild = (ChildClass)myClass;
        //myChild.ChildMethod();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Do Something Fun!
    }
}

//public class ParentClass {
//    void ParentMethod() {
//    }
//}

//public class ChildClass {
//    void ChildMethod() {
//    }
//}

/*
 *多態

允許擁有多個類型
在繼承層次結構中
任何子類都可以稱為父類
這表示在需要基類的時候
可以用派生類來替代它

多態也適用於函數參數
思考一下 OnTrigger函數
它們通過包含Collider參數
這個參數通常被稱作 other

多態的一種較為明智的用法
涉及構造函數和對象引用
你可以聲明基類類型的對象
然後調用其中一個派生類的構造函數

這是因為變量引用需要的是 基類的類型
子類的構造函數 會創建衍生類型的項

如果你感到困惑
只要記得子類是父類即可

因此這種轉換是有效的
這個過程被稱為 向上轉型
當對象向上轉型時 它只能
被視作其父類的一個對象

在示例中
子類向上轉型時
它只能被視作父類
這表示只能使用父類中
可用變量和方法
在使用時會把它們視作位於父類對象中

虛擬函數是一個例外
虛擬函數將調用"最新覆蓋版本"

有關虛擬函數和覆蓋虛擬函數的更多信息>參考

為了將這個子類 視作子類
我們需要向下轉型子類變量
使其恢復為子類類型
具體方式是
點運算符訪問
((Child)myClass).ChildMethod
或是 創建對這新版本的引用
ChildClass myChild = (Child)myClass; 
 */