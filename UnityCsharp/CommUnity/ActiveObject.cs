using UnityEngine;
using System.Collections;

public class ActiveObject : MonoBehaviour
{
    public GameObject myGameObject;

    void Start()
    {
        Debug.Log("Active Self: /" + myGameObject);
        Debug.Log("Active in Hierarchy: /" + myGameObject.activeInHierarchy);
        gameObject.SetActive(false);//關父對象
    }

    void Update()
    {

    }
}
