using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi48 : MonoBehaviour {
    void Start() {
        Math01();
        Math02();
        Math03();
        Math04();
    }

    public void Math01() {
        print("Math01");
        Stack<int> s = new Stack<int>();

        s.Push(123);
        s.Push(223);
        s.Push(323);

        int count = s.Count;
        bool b = s.Contains(1233);
        Debug.Log(count);
        Debug.Log(b);


        Debug.Log(s.Peek());


        int s1 = s.Pop();
        Debug.Log("s1 = " + s1);
        int s2 = s.Pop();
        Debug.Log("s2 = " + s2);
        int s3 = s.Pop();
        Debug.Log("s3 = " + s3);

        s.Clear();
        Debug.Log(s);
        Debug.Log(count);
    }

    public void Math02() {
        print("Math02");

        Queue<string> q = new Queue<string>();
        int count = q.Count;
        bool b = q.Contains("一");

        q.Enqueue("一");
        q.Enqueue("二");
        q.Enqueue("三");

        string s1 = q.Dequeue();
        string s2 = q.Dequeue();
        string s3 = q.Dequeue();
        Debug.Log("q1 = " + s1);
        Debug.Log("q2 = " + s2);
        Debug.Log("q3 = " + s3);
    }

    public void Math03() {
        print("Math03");

        Point p = new Point(2, 3);
        int g = p.Sum(3, 5);
        Debug.Log(g);
    }

    public void Math04() {
        print("Math04");

        PlayerStatus ps = new PlayerStatus();
        int a = (int)PlayerStatus.idle;
        int b = (int)PlayerStatus.walk;
        int c = (int)PlayerStatus.run;

        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);
    }

    struct Point {//建構式子彈 還帶些方法
        public int x;
        public int y;
        public Point(int a, int b) {
            x = a;
            y = b;
        }
        public int Sum(int a, int b) {
            return a + b;//有使用則是用這邊的
        }
    }

    enum PlayerStatus
    {//列舉
        idle,//系統編號從0開始
        walk,//編輯器撈資料則按照字首排列
        run,
        jump,
        attack,
        death,
        fire
    }
}

/* Note

在Stack中分配記憶體
在宣告的同時就初始化
以確保資料不為NULL

Stack儲存的數值類型變數
在超出其作用範圍後
所占記憶體會被系統釋放

區域變數 函式的參數與函式的位址等等
由系統管理 必須在編譯時期為已知

這些變數的回收會發生在它從堆疊pop出去的時候
因為個數、大小什麼的都是已知，所以系統知道怎麼進行配置與回收
 */