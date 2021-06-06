using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NF.Test {
    sealed partial class InterfaceInheritance_Par : IInterfaceInheritance_Inter {
        public static InterfaceInheritance_Par _instance;
        void Awake()
        {
            _instance = this;
        }

        public int X {
            get;
            set;
        }

        public int Y {//改了會錯
            get; //{ return Y; }
            set; //{ Y = value; }
        }

        public void Halo() {
            Debug.Log("Halo");
        }

        public void Vector(int vX, int vY) {
            X = vX;
            Y = vY;
            int sum = X + Y;
            Debug.Log(string.Format("X:{0}\t Y:{1}\t SUM={2}",X,Y,sum));
        }
    }
}