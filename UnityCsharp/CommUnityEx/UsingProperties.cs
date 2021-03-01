using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingProperties : MonoBehaviour
{
    void Start()
    {
        Cex.Player myPlayer = new Cex.Player();

        myPlayer.Experience = 1555;
        myPlayer.Health = myPlayer.Level * 150 + 90;

        int x = myPlayer.Experience;

        Debug.Log(string.Format("Obj ={0}\n Int x={1}", myPlayer, x));
        Debug.Log(string.Format("Lv{0}\n Hp{1}", myPlayer.Level, myPlayer.Health));
    }
}
/*
我們經常需要通過某種方法
從位於類以外的代碼
訪問這個類的成員變量

一種方法是公開變量然後直接訪問
雖然這個方法已經夠用 但還有更好的方法

那就是使用屬性
屬行本身可以當作變量
並且可以封裝成員變量
我們也稱之為字段
通過這種封裝 我們可以更好地控制
字段的訪問時間和訪問方式

我們要創建一個屬性
屬性語法的工作原理如下
首先指定訪問修飾符 然後指定類型後 跟屬性名稱

最好將屬性命名為 字段的名稱 
不同的是以大寫字母開頭
然後輸入{} 在裡面輸入屬性的訪問器
一個屬性可以有兩個訪問器  
引用屬性和分配屬性時
分別會調用 get set 這兩個函數 

    這裡我多使用了 namespace
*/
namespace Cex {
    public class Player {
        private int experience;

        public int Experience {
            get {
                return experience;
            }
            set {
                experience = value;
            }
        }

        public int Level {
            get {
                return experience / 1000;
            }
            set {
                experience = value * 1000;
            }
        }

        public int Health { get; set; }
    }
}

/*
 為什麼還要完成屬性創建的過程
 使用屬性可以執行兩項
 直接公開變量做不到的操作

*   第一 通過省略 get 或 set
    可以有效地將字段設置為
    只讀取 或只寫入

    如果字段是私有的
    那麼沒有 get訪問器就無法讀取該字段
    沒有set 訪問器就無法寫入該字段

*   第二 還可以將訪問器 視為函數
    這表示你可以在訪問器內部

    運行其他代碼或調用其他函數

    順著這思路可以推斷出使用 set訪問器
    用來啟動協同程序
    字段封裝不需要是直接的

    設想一個遊戲 玩家穫得經驗
    每一千點經驗 即可升等
    如果有一個字段代表經驗值
    就可以用屬性來代表玩家的等級

    等級屬性的get訪問器
    可以返回 Exp字段 / 1000 得到值
*   而不返回真實的經驗值
    這樣一來 它會返回數字等級

    此外 等級屬性可以有 set 訪問器
    用於接收等級
    和計算玩家所穫得的經驗數量
*   並將值 存檔在 exp字段中

    屬性的另一個特點是
*   它們可以被自動實現
    要創建自動實現的屬性
    可以使用簡寫語法
     */