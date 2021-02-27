using UnityEngine;
using System.Collections;

public class UtilitiesExample : MonoBehaviour
{
    private void Start()
    {
        int x = Utilities.Add(5, 6);
        Debug.Log("Ex: " + x);
    }
}
