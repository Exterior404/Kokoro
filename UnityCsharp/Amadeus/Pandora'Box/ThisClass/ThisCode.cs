using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThisCode : MonoBehaviour
{//轉換顏色代碼
    public GameObject obj;

    public Text title;
    public Color color;

    private void Start()
    {
        Debug.Log("準備使用擴展");
        obj.DoSomething();

        title.text = string.Format("<#{0}>{1}</color>",color.ToHex(),"Welcome Hell");
    }
}
