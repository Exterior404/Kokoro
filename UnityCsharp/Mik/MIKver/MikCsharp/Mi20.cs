using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi20 : MonoBehaviour
{//GetComponent測試
    Mik.Cat cat;
    private void Start() {
        Mik.Dog dog = new Mik.Dog();

        //沒繼承的寫法
        Person pr1 = new Person();
        Debug.Log(pr1.age);
        Debug.Log(pr1._name);

        //有繼承MonoBehaviour的寫法
        Person2 pr2;
        pr2 = this.GetComponent<Person2>();
    }



    public class Person
    {//沒有繼承MonoBehaviour的
        public int age;
        public string _name;
        public Person()
        {
            this.age = 25;
            this._name = "NF";
            Debug.Log("打印");
        }
    }

    public class Person2 : MonoBehaviour
    {//有繼承MonoBehaviour的
        public int height;
        public float weight;
        public string _name;

        public Person2() {
            this.height = 20;
            this.weight = 60;
            this._name = "CC";
            Debug.Log("Person2類的建構方法被呼叫了");
        }

        public void Walk() { }
        public void Run() { }
    }
}


namespace Mik { 
    public class GetComponentExample : MonoBehaviour {
        private void Start() {
            HingeJoint hinge = gameObject.GetComponent(typeof(HingeJoint)) as HingeJoint;

            if (hinge != null)
                hinge.useSpring = false;
        }
    }
}