using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Paskaita_Generics
{
    internal class TwoGenerics<T1, T2>
    {
        private T1 Value1;
        private T2 Value2;

        public TwoGenerics(T1 value1, T2 value2)
        {
            Value1 = value1;
            Value2 = value2;

        }

        public void PrintValues()
        {
            Console.WriteLine($"Value1 is {typeof(T1)}: {Value1}");
            Console.WriteLine($"Value2 is {typeof(T2)}: {Value2}");
        }

        public void SetProperty1(T1 newValue)
        {
            Value1 = newValue;
        }

        public void SetProperty2(T2 newValue)
        {
            Value2 = newValue;
        }

        public T1 GetProperty1()
        {
            return Value1;
        }

        public T2 GetProperty2()
        {
            return Value2;
        }
    }
}
