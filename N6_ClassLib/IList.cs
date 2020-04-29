using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6_ClassLib
{
    public interface IList<T> : IEnumerable<T>
    {
        void Add(T value);                          //добавление
        void Clear();                               //очистка
        bool Contains(T value);                     //проверяет наличие величины
        int IndexOf(T value);                       //поиск индекса
        void Insert(int index, T value);            //вставка (индекс+значение)
        void Remove(T value);                       //удаление по значению
        void RemoveAt(int index);                   //удаление по номеру
        IList<T> SubList(int fromInd, int toInd);   //возвращает подсписок
    }
}
