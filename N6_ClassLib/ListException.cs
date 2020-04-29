using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6_ClassLib
{
    //возможные исключения при работе со списком
    public class ListException : Exception
    {
        public ListException(string message) : base(message) { }
    }


}
