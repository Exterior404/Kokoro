using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour
{//攝影機追隨物體
    public Transform target;

    void Update()
    {
        transform.LookAt(target);
    }
}
