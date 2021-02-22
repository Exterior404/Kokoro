using UnityEngine;
using System.Collections;

public class LoopDoFor : MonoBehaviour
{//Note
    public int cupInTheSink = 4;

    void Start()
    {
        //LoopWhile();
        //LoopDoWhile();
        //LoopFor();
    }

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
}