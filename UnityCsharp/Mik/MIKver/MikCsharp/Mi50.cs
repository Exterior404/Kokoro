using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi50 : MonoBehaviour
{
    public int[] kokoko = new int[3];

    void Start()
    {
        PlayerStatus ps = new PlayerStatus();

        int a = (int)PlayerStatus.walk;
        int b = (int)PlayerStatus.run;
        int c = (int)PlayerStatus.idle;
        Debug.Log(string.Format("a = {0} b = {1}", a ,b));
        Debug.Log(c);
    }


    struct Point
    {//建構式子彈 還帶些方法
        public int x;
        public int y;
        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public int Sum(int a, int b)
        {
            return a + b;//有使用則是用這邊的
        }
    }

    enum PlayerStatus : byte
    {
        walk,
        run,
        attack,
        idle,
        sleep,
        die,
        jump
    }
}
