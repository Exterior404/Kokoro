using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidSc2 : MonoBehaviour
{//示範用代碼
    public string mes;

    public byte age = 1;
    public bool license;

    public bool boA;
    public bool boB;
    public bool boC;

    void Start()
    {
        Methed();
        //MethedFix();
        //MethedFix2();
        Methed2();
        //Methed2Fix();
        //Methed2Fix2();
        FixMethed();
    }

    void Methed()
    {//進站前你是否滿十八歲
        if(age >= 18)
        {
            mes = "你可以進站看";
        }
        else
        {
            mes = "十八歲以上才能觀看";
        }
    }

    void MethedFix()
    {//進站前你是否滿十八歲
        if (age >= 18)
            mes = "你可以進站看";
        else
            mes = "十八歲以上才能觀看";
    }

    void MethedFix2()
    {//進站前你是否滿十八歲
        mes = age >= 18 ? "你可以進站看" : "十八歲以上才能觀看";
    }

    void Methed2()
    {//你是否可以騎車
        if (age >= 18)
        {
            if (license)
            {
                mes = "滿十八歲以上 且有駕照";
            }
            else
            {
                mes = "要有駕照哦";
            }
        }
        else
        {
            mes = "滿十八去考駕照哦";
        }
    }

    void Methed2Fix()
    {//你是否可以騎車
        if (age >= 18)
            if (license)
                mes = "滿十八歲以上 且有駕照";
            else
                mes = "要有駕照哦";
        else
            mes = "滿十八去考駕照哦";
    }

    void Methed2Fix2()
    {//你是否可以騎車
        if (age >= 18) // ?:可以嵌套 只是不想寫 還有註解別學我↓
            mes = license ? "滿十八歲以上 且有駕照" : "要有駕照哦";
        else
            mes = "滿十八去考駕照哦";
    }

    void FixMethed()
    {//碰到就彈出
        if (age < 18) {
            mes = "十八歲以上才能觀看";
            return;
        }

        if (!license) {
            mes = "要有駕照哦";
            return;
        }

        if (!boA)
            return;

        if (!boB)
            return;

        if (!boC)
            return;

        mes = "五個檢查已通過";
    }
}