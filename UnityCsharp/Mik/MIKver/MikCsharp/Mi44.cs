using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi44 : MonoBehaviour
{//二維陣列
    int[] array_a = new int[8] { 13, 28, 31, 47, 53, 60, 77, 23 };
    int[,] array_aa = new int[2, 3] { { 1, 2, 3 }, 
                                      { 4, 5, 6 } };

    int[,,] housees = new int[2, 4, 3] { 
        { {1,2,3 },{4, 5, 6 },{3, 1, 2 },{7, 2, 3 } }        
        ,{ {7, 8, 9 },{8, 9, 0 },{3, 1, 2 },{2, 1, 4 } } 
    };
}
