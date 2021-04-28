using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mik {
    public class Mi26 : MonoBehaviour {
        void Start() {
            Man man = new Man();
            man.Walk();
            man.Walk(3);
            man.Walk(3, 5);
            man.Myname("NF");
            man.Myname(27);
        }
    }

    /// <summary>
    /// 人類的基礎類
    /// </summary>
    public class Person {
        public Person() {
            Debug.Log("人類的建構方法被呼叫了");
        }

        public void Myname(string str) {
            Debug.Log("人類的名稱是" + str);
        }
    }

    /// <summary>
    /// 男生(衍生類
    /// </summary>
    public class Man : Person {
        public int age = 25;
        public float weight = 65;
        public float height = 175;

        public void Walk() {
            Debug.Log("走路的方法被呼叫了");
        }

        public void Walk(float speed) {
            Debug.Log("帶速度的走路方法被呼叫了");
        }

        public void Walk(float speed, float distance) {
            Debug.Log("帶速度+距離的走路方法被呼叫了");
        }

        public void Myname(int age) {
            Debug.Log("我是基礎類的方法重載 改年紀" + age);
        }
    }
}