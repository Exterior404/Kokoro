using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi47 : MonoBehaviour
{//List<T>Array  如果資料少可以去用 ArrayList

    private void Start() {
        //List<T> Array = new List<T>();
        Mik.PersonListArray person = new Mik.PersonListArray();
        List<PlayerPrefs> LaPerson = new List<PlayerPrefs>();

        //string[] str = new string[6];//舊版如此 新版更強
        List<string> arr_str = new List<string>();//一維陣列

        //ArrayList中對元素類型沒有限制, List對元素類型有限制

        //添加元素使用Add()方法
        arr_str.Add("Welcom");
        arr_str.Add("Hell");
        arr_str.Add("C#");

        //使用Inser()方法插入元素
        //把字符串 插入下標為 1 的位置

        arr_str.Insert(1, "NF");

        //使用Remove()方法刪除指定元素
        arr_str.Remove("Hell");

        //使用RemoveAt()方法刪除指定下標的位置
        arr_str.RemoveAt(1);

        int c = arr_str.Count;

        bool b = arr_str.Contains("NF");
        if (b) Debug.Log("存在在其中");
        else Debug.Log("不存在於其中");

        //a 可以使用下標訪問List中的元素
        arr_str[0] = "你好";
        string str = arr_str[1];
        Debug.Log(str);

        //使用Clear()清空整個List
        arr_str.Clear();

        //ArrayList  對元素的類型沒有限制
        ArrayList a = new ArrayList();
        a.Add("hello");
        a.Add(14);
        a.Add("15.67f");

        //因為對 ArrayList對元素類型沒有限制 系統會把這些元素當做 object類型對象存起來
        string s = (string)a[0];
    }
}


namespace Mik {
    class PersonListArray {

    }
}

/* Note
List<T>
 這個T代表資料類型

例如
List<Int> 就是代表一個整數類型的陣列
List<String>就是代表一個字串類型的陣列
List<Person>就是代表一個Person類型的陣列

T就好比是方法中的參數
可以替換
可以把它當做公式來理解
整體當作記號來理解
本質上就是一個陣列

使用Lsit<T>
要使用命名空間
System.Collections.Generic
 */

/* ArrayList 裝拆箱Note 
 必須先 裝箱再拆箱
裝箱就是隱式的將一個實值類型轉換為參考類型物件

int i = 0;
System.Object obj = i;
這個過程就是裝箱 將i裝起來

拆箱就是將一個參考的類型物件轉換成任意實值類型

int i = 0;
System.Object obj = i;
int j = (int)obj; // obj as int
這個過程前兩句是裝箱
後一句是拆箱
 
添加到ArrayList中的任何資料或是資料型別
都會向上隱式強製轉化成Object
如果是資料型別 則必須在將其添加
到列表中時進行裝箱操作
在檢索時進行拆箱操作

如果是對大型集合進行迴圈取值的情況
這種不斷的強制轉換以及裝拆箱的操作都會降低性能

而List<T> 可以避免以上的情況
不會強行對資料型別進行裝拆箱
或對參考類型進行向下強制類型轉換
所以可以提高系統性能
 */

