using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6_ClassLib
{
    //звено списка
    public class Node<T>
    {
        public T Key;          //значение
        public int Index;      //индекс элемента
        public Node<T> Lower;  //соответственный нижний элемент
        public Node<T> Next;   //соседний элемент

        public Node(T _key, Node<T> _low, Node<T> _next)
        {
            Key = _key;
            Lower = _low;
            Next = _next;
        }
    }
    
    public class LinkedSkipList<T> : IList<T>
    {
        List<Node<T>> Level;
        Node<T> head;
        Node<T> tail;

        LinkedSkipList<T> BuildLvl(LinkedSkipList<T> _lvl)
        {
            LinkedSkipList<T> _next = new LinkedSkipList<T>();
            _next.head.Lower = _lvl.head;
            _next.tail.Lower = _lvl.tail;
            Node<T> i = _lvl.head.Next.Next;
            Node<T> cur = _next.head;
            while (i != null && i.Next != null)
            {
                cur.Next = new Node<T>(cur.Key, i, cur.Next);
                cur = cur.Next;
                i = i.Next.Next;

            }
            return _next;
        }

        LinkedSkipList<T> BuildList(LinkedSkipList<T> _list)
        {
            LinkedSkipList<T> lvl = new LinkedSkipList<T>();
            Node<T> i = _list.tail;
            Node<T> j = _list.head;
            //построение первого уровня
            while (j != _list.tail)
            {
                i.Next = new Node<T>(j.Key, null, j.Next); 
                i = i.Next;
                j = j.Next;
            }
            //пока к-во элементов на текущем уровне >2, каждый второй перекидываем на новый уровень
            while (lvl.Count() > 2)
            {
                lvl = BuildLvl(lvl);
            }
            return lvl;
        }

        public void Add(T value)
        {
            
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T value)
        {
            throw new NotImplementedException();
        }

        public void Remove(T value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public IList<T> SubList(int fromInd, int toInd)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}