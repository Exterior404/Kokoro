using UnityEngine;
using System.Collections;

public class StaticPlayerManager : MonoBehaviour
{
    private void Start()
    {
        int x = StaticPlayer.playerCount;
        Debug.Log("Player Count : " + x);

        Game game = new Game();
        Debug.Log(game);
    }
}
/*
 靜態成員
如變量和方法
是跨類的所有實例
共享的成員
此外 靜態成員可直接通過類訪問
無需先對類的對象 進行實例化

通常成員變量對於類的
每個對象是唯一的
雖然類的每個對象具有相同的變量
但他們各有自己的值
然而 對於靜態變量
類的每個對象具有相同的變量 和相同的值

因此如果在一處更改某個靜態變量的值
則所有其他靜態變量的值也將更改

與靜態變量一樣  靜態方法屬於類 
而不屬於類的特定對象 (Objt?)
Input系統就是靜態的 GetAxis GetKey都是靜態方法
之所以能判斷是靜態 是因為不需要通過實例化

事實上Unity提供了許多靜態方法
需要注意的是
不能在靜態方法內部
使用非靜態類成員變量
記住靜態方法屬於類

而非 靜態變量屬於 類的實例

你可以把整個類 弄成靜態
結果就是 類成為靜態 並且
不能創建類的實例
如果想要使類完全由
靜態變量和方法組成 例如Input類 則這樣非常有用
     */
