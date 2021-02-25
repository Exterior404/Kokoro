using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticPlayer : MonoBehaviour
{
    public static int playerCount = 0;

    private void Start()
    {
        playerCount++;
    }
}

public class Game
{
    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();

        int x = Enemy.enemyCount;
        Debug.Log("Game x :" + x);
    }
}


public class Enemy
{
    public static int enemyCount = 0;

    public Enemy()
    {
        enemyCount++;
    }
}

public static class Utilities
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}