using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int projectileA;
        public int projectileB;
        public int projectileC;

        public float fuel;

        public Stuff(int prA, int prB, int prC)
        {
            projectileA = prA;
            projectileB = prB;
            projectileC = prC;
        }

        public Stuff(int prA, float fu)
        {
            projectileA = prA;
            fuel = fu;
        }

        public Stuff()
        {//默認變數數值為 1
            projectileA = 1;
            projectileB = 1;
            projectileC = 1;
        }
    }

    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50, 1.5f);

    private void Start()
    {
        Debug.Log(myStuff.projectileA);
    }
}