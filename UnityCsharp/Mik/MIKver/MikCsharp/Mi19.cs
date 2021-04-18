using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi19 : MonoBehaviour
{//主要用來建構物件用的
    int a = 5, b = 10;

    void Start() {
        Mi19 mi19 = new Mi19();


        Dog dog = new Dog();
        Debug.Log(dog.dogAge);

        dog.dogAge = dog.dogAge * 2;
        dog.dogHeight = dog.dogHeight * 2;
        dog.dogWeight = dog.dogWeight * 2;
        Debug.Log(dog.dogAge);

    }//自訂義方法 建構式

    public class Person {
        public int age;
        public string _name;
        //建構方法

        public Person() {
            this.age = 17;
            this._name = "NF";
        }//建構子 要跟類名一樣
    }


    public class Dog {
        public int dogAge;
        public float dogHeight;
        public float dogWeight;

        public Dog() {
            this.dogAge = 3;
            this.dogHeight = 100;
            this.dogWeight = 10;

            Debug.Log("Dog的建構方法被呼叫了");
        }//自定義的方法
    }

    public class Cat {
        int catAge = 5;
        float catHeight = 50;
        float catWeight = 5;

        void CatWalk() {

        }
    }
}