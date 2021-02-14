﻿using UnityEngine;
using System.Collections;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;

    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
    }


    void Start()
    {
        Debug.Log("The player's score is " + anotherScript);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + "Times");
    }
}