using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6_ClassLib
{
    //интерфейс
    public interface IList<T>: IEnumerable<T>
    {
        int Add(T value);                           //добавление
        void Clear();                               //очистка
        bool Contains(T value);                     //проверяет наличие величины
        int IndexOf(T value);                       //поиск индекса
        void Insert(int index, T value);            //вставка (индекс+значение)
        void Remove(T value);                       //удаление по значению
        void RemoveAt(int index);                   //удаление по номеру
        IList<T> subList(int fromInd, int toInd);   //возвращает подсписок
    }

    //возможные исключения при работе со списком
    public class ListException
    {

    }

}
