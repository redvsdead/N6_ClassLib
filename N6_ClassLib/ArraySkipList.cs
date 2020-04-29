using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6_ClassLib
{
    //список с пропусками на основе массива
    class ArraySkipList<T>
    {
        public const int m = 100;
        T[,] _List = new T[m, m];
    }

}
