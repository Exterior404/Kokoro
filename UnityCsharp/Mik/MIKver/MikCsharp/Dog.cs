using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mik {
    public class Dog {
        public int dogAge;
        public float dogHeight;
        public float dogWeight;

        public Dog() {
            this.dogAge = 10;
            this.dogHeight = 100;
            this.dogWeight = 15;

            Debug.Log("Dog的建構方法被呼叫了");
        }
    }
}