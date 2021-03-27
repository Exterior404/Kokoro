using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DialogSystem : MonoBehaviour
{//對話系統

    [Header("UI組件")]
    public Text textLabel;
    public Image faceImage;

    [Header("文本文件")]
    public TextAsset textFile;
    public int index;
    public float textSpeed;

    [Header("角色頭貼")]
    public Sprite face01, face02;
    
    bool textFinished;//文字是否打完
    bool cancelTyping;//取消打字(快轉)

    List<string> textList = new List<string>();

    void Awake()
    {
        GetTextFormFile(textFile);
    }

    private void OnEnable()
    {//啟動一開始發動 (注意會搶在Start前使用
     //textLabel.text = textList[index];
     //index++;
        textFinished = true;
        StartCoroutine(SetTextUI());
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && index == textList.Count)
        {//因為下方用For 所以用完要馬上關閉
            gameObject.SetActive(false);
            index = 0;
            return;
        }

        //if (Input.GetKeyDown(KeyCode.R) && textFinished)
        //{//輸出文本內容
        //    //textLabel.text = textList[index];
        //    //index++;
        //    StartCoroutine(SetTextUI());
        //}

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (textFinished && !cancelTyping)
            {//文字打完之前 且 沒取消打字
                //textLabel.text = textList[index];
                //index++;


                //if (textLabel.text == "txtCL")
                //{
                //    textLabel.text = "";
                //}

                StartCoroutine(SetTextUI());
            }
            else if (!textFinished && !cancelTyping)
            {//直接快速打字用
                //cancelTyping = !cancelTyping; //一種特殊技巧
                cancelTyping = true;
            }
        }
    }

    void GetTextFormFile(TextAsset file)
    {//Txt裝進List
        textList.Clear();
        index = 0;

        //因為原本是數組 所以要轉換
        var lineDate = file.text.Split('\n', '\t');


        foreach (var line in lineDate)
        {//將切好的文本 排成列表
            textList.Add(line);
        }

        for (int i = 0; i < textList.Count; i++)
        {//後台檢測用
            //Debug.Log(textList[i]);
            Debug.Log(string.Format("textList[{0}] = {1}", i, textList[i]));
        }
    }

    IEnumerator SetTextUI()
    {//讓文字有動態 
        textFinished = false;
        textLabel.text = "";//進入下一行，之前就清空原本的文字

        switch (textList[index])
        {//變數控制器  換頭貼用..etc  
            case "Face01":
                faceImage.sprite = face01;
                index++;
                break;
            case "Face02":
                faceImage.sprite = face02;
                index++;
                break;
        }

        //for (int i = 0; i < textList[index].Length; i++)
        //{//逐字打印
        //    textLabel.text += textList[index][i];
        //    yield return new WaitForSeconds(textSpeed);
        //}

        int letter = 0;
        while (!cancelTyping && letter < textList[index].Length -1)
        {//可以跳出的打印
            textLabel.text += textList[index][letter];
            letter++;

            yield return new WaitForSeconds(textSpeed);
        }
        textLabel.text = textList[index];

        cancelTyping = false;
        textFinished = true;

        index++;
    }
}
