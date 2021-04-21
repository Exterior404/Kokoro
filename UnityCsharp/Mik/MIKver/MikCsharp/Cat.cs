using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mik {
    public class Cat : MonoBehaviour {
        public int catAge;
        public float catHeight;
        public float catWeight;

        public Cat() {
            this.catAge = 25;
            this.catHeight = 75;
            this.catWeight = 5;
            Debug.Log("Cat的建構方法被呼叫了");
        }
    }
}