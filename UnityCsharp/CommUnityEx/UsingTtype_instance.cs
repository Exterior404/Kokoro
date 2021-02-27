using UnityEngine;
using System.Collections;

public class UsingTtype_instance : MonoBehaviour
{
    private void Start()
    {
        Ttype.SomeClass someClass = new Ttype.SomeClass();

        someClass.GenericMethod<int>(5);

        // Generic Example

        GenericClass<int> myClass = new GenericClass<int>();
        Debug.Log(someClass);
        Debug.Log(myClass);
    }
}

public class GenericClass<T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
/*
這個類使用泛型類型T
這意味著在使用時
在類中用作類型的
類型T的
每個實例將替換為實際類型

這個類有一個變量
名叫 item 類型為T
*/
}
namespace Ttype {
    public class SomeClass
    {
        public T GenericMethod<T>(T param)
        {
            return param;
        }

        public T GenericMethod<T, U, V>(T param)
        {
            return param;
        }

        public T GenericMethod1<T>(T param) where T : class
        {//引用或是使用
            return param;
        }

        public T GenericMethod2<T>(T param) where T : struct
        {//確保為值類型
            return param;
        }

        public T GenericMethod3<T>(T param) where T : new()
        {//不含參數的公共構造函數
            return param;
        }

        public T GenericMethod4<T>(T param) where T : MonoBehaviour
        {//繼承過來為衍生類
            return param;
        }

        public T GenericMethod5<T>(T param) where T : IEnumerable
        {//接口
            return param;
        }
    }

}
/*
 * 泛型
是一種特徵 通過該特徵
類型可以作為參數
傳遞給類和方法等

實際上 這允許你在不了解
所處理數據的確切類型的情況下
進行一般編程
我們之前已看到過 
GetComponent 方法
使用泛型參數來獲取
其所尋找的組件的類型

GetComponent就是泛型方法
<>內通常使用 T, U, V
雖然泛型函數不權限於三個參數
但很少看到人們使用超過三個參數

現在我們知道與這個方法
關聯的泛型類型就是T
但T只是一個 占位符
調用這個方法時
T最終會成為實際類型
無論T最終成為什麼類型

這個類型也將成為
方法的返回類型 和參數類型
因為它們都使用T作為其類型

即使我們有一個方法可使用泛型類型
但目前還不是很有用

泛型類型有什麼作用呢
由於我們不知道這個泛型類型的行為方式
所以能做的操作不多
這個泛型參數可以是任意值 浮點數 模型行為等
由於我們不知道它是什麼
所以能對它執行的運算很少

例如 我們不能用模型行為乘2
我們不能訪問浮點數的遊戲對象字段
目前 我們將它當作類對象
進行處理 這是基類

所有C#類 隱式地從基類繼承而來
如何才能執行更多運算呢
為了解類型的一些特徵
我們必須限制可能的類型
方法是對泛型參數施加限制
為了給函數添加限制

我們在參數之後
函數主體之前輸入 where 後
跟我們限制的泛型類型 
即本例的T 然後打入冒號
在 : 後 用逗號隔開
具體的限制

限制通常分為四個類別
可以使用關鍵字class 來確保
可以使用關鍵字new後  跟 
一對圓括號來確保它具有
不含參數的公共構造函數

可以使用類名 來表示 T就代表這個類
或通過多態表示 代表從中衍生的任意類
最後一個限制類別是 接口
你可以使用接口名稱來表示 T
已實現這個接口
為使用泛型方法
必須指定希望它使用的具體類型
假設你想要使用
剛剛創建的泛型方法

在另一個類中
你可以寫入方法名<> 裡面是你想要的類型
然後()寫入任意參數
我們討論的所有特徵都適用於
GenericClass和接口及方法
通過類指定泛型類型
你可以影響其中的字段 屬性和方法的類型
創建G類是泛型的 一種較為常見的用法
有助於實現數據結構
*/