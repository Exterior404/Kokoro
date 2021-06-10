using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usIBox : MonoBehaviour
{
    usBook usBook1;
    usBook usBook2;
    void Start()
    {
        usBook1.id = 1;
        usBook1.num = 1;
        usBook1.number = 1;

        usBook2.id = 2;
        usBook2.num = 1;
        usBook2.number = 1;

        Debug.Log(string.Format("Book 1 {0}{1}{2}{3}", usBook1, usBook1.id, usBook1.num, usBook1.number));
    }

}

public struct usBook : IBoxB
{
    public int num { get; set; }
    public int id { get; set; }
    public int number;
};

public abstract class usIBox2 : NF.Test.IBoxA
{
    public abstract void Hello();
}