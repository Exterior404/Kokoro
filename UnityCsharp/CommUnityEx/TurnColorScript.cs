using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void OnEnable()
    {
        CUEvent.OnClicked += TurnColor;
    }

    private void OnDisable()
    {
        CUEvent.OnClicked -= TurnColor;
    }

    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}