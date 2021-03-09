using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CueList : MonoBehaviour
{
    private void Start()
    {
        List<Badguy> badguys = new List<Badguy>();

        badguys.Add(new Badguy("Harver", 50));
        badguys.Add(new Badguy("Magneto", 100));
        badguys.Add(new Badguy("Pip", 5));

        //badguys.Count;//用於總數量
        //RemoveAt用移除 Insert

        badguys.Sort();//依賴IComparable
        foreach (Badguy guy in badguys)
        {
            Debug.Log(guy.name + " " + guy.power);
        }

        badguys.Clear();
        //-------------------------

        Dictionary<string, Badguy> badguys2 = new Dictionary<string, Badguy>();

        Badguy bg1 = new Badguy("Harvey2", 50);
        Badguy bg2 = new Badguy("Magneto2", 100);

        badguys2.Add("gangster", bg1);
        badguys2.Add("mutant", bg2);

        Badguy magneto = badguys2["mutant"];
        Badguy temp = null;

        if(badguys2.TryGetValue("birds", out temp))
        {

        }
        else
        {

        }
    }
}

public class Badguy :IComparable<Badguy>
{//列表
    public string name;
    public int power;

    public Badguy(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }

    public int CompareTo(Badguy other)
    {//IComparable<T>有寫時 就寫這個
        if (other == null) return 1;
        return power - other.power;
    }
}

/*
 * List Dictionaries
兩個泛型集合 列表 字典
二者的工作原理類似數組
但有一些明顯區別

List類
列表就像是大小動態變化的數組
這表示你不需要提前知道
列表將包含多少個元素

一個可以存儲在列表中的類
列表是泛型類
因此可以存儲任意類型
*/