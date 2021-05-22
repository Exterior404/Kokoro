using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi28 : MonoBehaviour
{//C# Class 繼承 重載 重寫 隱藏 (移植
    void Start() {
        Man man = new Man();
        Girl girl = new Girl();
        Panda panda = new Panda();

        man.Walk();
        man.Walk(50.0f);//虛擬
        man.Walk(30.0f, 60.0f);

        girl.Walk();//隱藏Per方法
        girl.Walk(25.0f);//因沒girl 使用Per

        panda.Walk(120.0f);//自私的貓一路衝最快
    }
}

public class Person {
    public Person() {
        Debug.Log("創建了一個Per的物件");
    }

    public void Walk() {
        Debug.Log("walk基礎類別的創建");
    }

    public virtual void Walk(float speed) {
        Debug.Log("Per 的VR walk");
    }

    public void walk(float speed, float time) {
    }
}

public class Man : Person
{
    public int manAge = 20;
    public float manHeight = 175;
    public float manWeight = 65;

    public Man() {
        Debug.Log("創建了一個男生");
    }

    public void Walk() {
        Debug.Log("這是一個 Man 走路的方法");
    }

    public void Walk(float speed) {
        Debug.Log("Man 走路速度 = " + speed);
    }

    public void Walk(float speed, float time) {
        float a;
        a = speed * time;
        Debug.Log("Man 走的距離大約是 = " + a);
    }
}

public class Girl : Person
{ //不能再衍生的class
    public int girlAge;
    public float girlWeight;
    public float girlHeight;


    public Girl()     {
        this.girlAge = 17;
        this.girlHeight = 160.0f;
        this.girlWeight = 45.0f;
        Debug.Log("創建了一個女生");
    }

    new private void Walk()     {
        Debug.Log("隱藏Per方法");
    }
}

public class Panda : Person {
    public sealed override void Walk(float speed) {
        Debug.Log("Panda Per = " + speed);
    }
}

//自閉式類別+重寫方法
public class Abc {
    public virtual void DoWork(int a) { }
}

public sealed class Daa : Abc {
    public sealed override void DoWork(int a) { }
}
