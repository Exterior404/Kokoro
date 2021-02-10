using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha;

    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    private void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    private void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}

public class AnotherClass
{
    public int apples;
    public int bananas;

    private int stapler;
    private int sellotape;

    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("OfficeSort Supplies total: " + answer);
    }
}