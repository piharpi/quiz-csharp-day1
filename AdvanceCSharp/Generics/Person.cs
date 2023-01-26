using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp.Generics
{
    internal class Person<T>
    {
        public T DisplayInfo(T value)
        {
            return value;
        }
    }
}
