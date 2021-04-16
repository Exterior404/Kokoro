using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mi14 : MonoBehaviour
{
    public Text numberText;
    public byte number = 255;

    void Start()
    {
        numberText.text = number.ToString();
        
    }
}
