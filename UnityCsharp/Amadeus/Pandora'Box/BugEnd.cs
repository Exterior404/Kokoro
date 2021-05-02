using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugEnd : MonoBehaviour {
    private void Start() {
        ;;;;;;//不會有事
        //Ex01();
    }

    void Ex01() {
        for(; ; ) {
            Debug.Log("可以運行，但會當機");
        }
    }
}