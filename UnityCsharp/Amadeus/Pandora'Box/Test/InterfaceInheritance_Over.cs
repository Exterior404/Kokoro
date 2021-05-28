using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NF.Test
{
    sealed partial class InterfaceInheritance_Par : InterfaceInheritance_Base
    {
        public override void Base01()
        {
            base.Base01();
            Debug.Log("Over");
        }

        void Start()
        {
            InterfaceInheritance_Par stPar = new InterfaceInheritance_Par();
            stPar.Halo();

            Base01();
            Halo();
            Vector(5, 6);

            stPar.Y = 4;
            Debug.Log(stPar.Y);
        }
    }
}