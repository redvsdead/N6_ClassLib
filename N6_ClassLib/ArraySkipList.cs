using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6_ClassLib
{
    //список с пропусками на основе массива
    public class ArraySkipList<T> : IList<T>
    {
        public const int m = 100;           //максимальное к-во уровней
        public T[,] _List;
        public int lvls;                    //настоящее к-во уровней

        public ArraySkipList()
        {
            _List = new T[m, m];
            lvls = 0;               //количество уровней = 0
        }

        public bool IsEmpty()
        {
            return lvls == 0;
        }

        public void Clear()
        {
            lvls = 0;
        }

        public void Add(T value)         
        {
            if (lvls == 0)
            {
                ++lvls;
            }
        }

        public bool Contains(T value)
        {
            return true;
        }

        public int IndexOf(T value)
        {
            return 0;
        }

        public void Insert(int index, T value)
        {

        }

        public void Remove(T value)
        {

        }

        public void RemoveAt(int index)
        {

        }

        public IList<T> SubList(int fromInd, int toInd)
        {
            IList<T> _List = new ArraySkipList<T>();
            return _List;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }

}
