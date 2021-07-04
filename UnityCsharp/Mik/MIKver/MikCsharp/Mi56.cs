using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mik.SetGet {
    public class Mi56 : MonoBehaviour {
        void Start() {

        }
    }

    public class Person {
        private string name;
        private int number;
        //上下是對應的寫法 只讀的方法
        public string GetName() {
            return name;
        }

        public int GetNumber() {
            return number;
        }

        //Set 寫入Name的方法
        public string SetName(string value) {
            return name = value;
        }

        //修飾詞 屬性類型 屬性名
        // set get 合在一起用
        public string Name
        {//value 只有在屬性Set中有意義，表示外面傳來的值            
            set { name = value; }
            get { return name; }
        }

        //--

        private int age = 17;

        public int Age {
            get { return age; }
        }//只讀

        private float h = 1.45f;

        public float H {
            set { H = value; }
        }//只寫
    }
}

/*
    為什麼SetGet這樣設計

比如我們的OS在新建用戶或
是在共享文件的時候
經常會提示對某個用戶的權限是什麼
是只讀還是只寫還是都可以

這裡的讀寫就類似SetGet

對於類別來說 如果不用SetGet
直接用public定義某個屬性
那這個也是可讀也可寫的

但如果你希望一個類別的某屬性是
只能讀不能寫入的時候
上面用public 定義某個屬性就不行了

我們可以使用private來定義屬性
再定義一個get方法
不定義set方法來實現

反之亦同
 */