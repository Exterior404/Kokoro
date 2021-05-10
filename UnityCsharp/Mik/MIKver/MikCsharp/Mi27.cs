using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mik {//隱藏 衍生類使用的基類方法
    public class Mi27 : MonoBehaviour {

        void Start() {
            ElectricCar electricCar = new ElectricCar();
            electricCar.AddOil("不用加油\n");
            electricCar.Walk();
            electricCar.AddMothed();//這是基礎類的方法
        }

        public class Car {
            public int a = 20;

            public Car() {
                Debug.Log("車類的基礎建構方法被呼叫了");
            }

            public void AddOil(string str) {
                Debug.Log("加油的種類" + str);
            }

            public virtual void Walk() {
                Debug.Log("車的啟動方法");
            }

            public void AddMothed() {
                Debug.Log("單純添加");
            }
        }

        public class ElectricCar : Car {
            public ElectricCar() {
                Debug.Log("電動車的建購方法");
            }

            public override void Walk() {
                base.Walk();//原本的方法內容
                Debug.Log("電動車的改寫啟動方法");
            }

            public new void AddOil(string str) {
                Debug.Log("加油的的方法被隱藏" + str);
            }//隱藏
        }
    }


    /*
     用來把基礎類的某些方法隱藏起來
     車類 (基礎) 大部份都有加油
     但電動車(衍生) 並不需要
     所以就把車類的加油給隱藏起來

     使用關鍵字 new
    */
}