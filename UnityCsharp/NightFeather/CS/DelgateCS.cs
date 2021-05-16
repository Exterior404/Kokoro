using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NF {
    public class DelgateCS : MonoBehaviour {

        public delegate void XD1();
        public XD1 myDelegate1;//默認null
        public XD1 myDelegate2;
        public XD1 myDelegate3;

        void Start() {

            myDelegate1 = delegate () { Debug.Log("HI"); };
            myDelegate1();

            //-------------

            myDelegate2 = delegate () { Debug.Log("A"); };
            myDelegate3 = delegate () { Debug.Log("B"); };

            myDelegate1 = myDelegate2 + myDelegate3;
            myDelegate1();

            //-------------

            myDelegate2 = null;
            myDelegate3 = Meth01;
            myDelegate1 = Meth02;

            myDelegate1 += myDelegate2 + myDelegate3;
            myDelegate1();
        }

        void Meth01() {
            Debug.Log("ABC");
        }

        void Meth02() {
            Debug.Log("DEF");
        }
    }
}