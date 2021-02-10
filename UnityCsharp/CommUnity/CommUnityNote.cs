using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommUnityNote : MonoBehaviour
{
    #region Loop
    int cupInTheSink = 4;

    void LoopWhile()
    {
        while (cupInTheSink > 0)
        {//持續判斷
            Debug.Log("I've washed a cup!");
            cupInTheSink--;
        }
    }

    void LoopDoWhile()
    {
        bool shouldContinue = false;

        do
        { //先執行這邊的內容 才進入判斷條件
            print("Hello World");
        } while (shouldContinue == true);// <- 後做判斷 ;
    }

    void LoopFor()
    {
        int numEnemies = 3;

        for (int i = 0; i < numEnemies; i++)
        {//變量 條件 迭代值
            Debug.Log("Creating enemy number: " + i);
        }
    }
    #endregion

    private void Start()
    {

    }
}

/*
 01 行為組件腳本
 02 變數和函數       ExampleBehaviourScript
 03 約定和語法       VariablesAndFunctions
 04 IF 語句         IfStatements
 05 For Loop*
 06 作用域和訪問修飾符ScopeAndAccessModifiers
 07 Awake & Start   AwakeAndStart
 08 Update & Fixed* UpdateAndFixedUpdate
 09
 10
 11
 12
 13
 14
 15
 16
 17
 18
 19
 20
 21
 22
 23
 24
 25
 26
 27
     */
