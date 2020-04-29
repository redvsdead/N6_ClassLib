using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6_ClassLib
{
    //звено списка
    class Node<T>
    {
        T Key;      //значение
        int index;  //индекс элемента
    }

    //список с пропусками на основе связного списка
    class LinkedSkipList<T>
    {
        List<List<Node<T>>> _List;  //список списков звеньев
    }

}