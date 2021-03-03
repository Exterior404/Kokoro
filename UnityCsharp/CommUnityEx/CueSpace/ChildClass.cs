using UnityEngine;
using System.Collections;

namespace CUE {
    public class ChildClass : CUE.ParentClass {

        float SomeValue = 5.0f;

        void Start()
        {
            Debug.Log(SomeValue);
        }

        void SayHello()
        {
            
            // Do it
        }
    }
}