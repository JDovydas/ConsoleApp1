using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Paskaita_Generics
{
    public class MySelfMadeList<T>
    {
        public T[] MyArray { get; set; }
        private int Index = 0;
        private int Size = 10;

        public MySelfMadeList()
        {
            MyArray = new T[Size];
        }

        public void AddElement(T elementToAdd)
        {
            if (CheckIfFull())
                MyArray = IncreaseListSize();
            if (elementToAdd != null)
            {
                MyArray[Index] = elementToAdd;
                Index++;
            }
            else
            {
                throw new ArgumentNullException(nameof(elementToAdd));
            }
        }
        private bool CheckIfFull()
        {
            if (Index == Size)
                return true;
            else
                return false;
        }
        private T[] IncreaseListSize()
        {
            Size += (Size / 2);
            var newArray = new T[Size];
            MyArray.CopyTo(newArray, 0);
            return newArray;
        }

        public void RemoveElement(T elementToRemove)
        {

            int foundIndex = -1;
            if (elementToRemove != null)
            {
                for (int i = 0; i < MyArray.Length; i++)
                {
                    if (MyArray[i].Equals(elementToRemove))
                    {
                        foundIndex = i;
                        break;
                    }
                }
                if (foundIndex != -1)
                {
                    int counter = 0;
                    for (int i = 0; i < MyArray.Length; i++)
                    {
                        if (i != foundIndex)
                        {
                            MyArray[counter] = MyArray[i];
                            counter++;
                        }

                    }
                    Index--;
                }
            }















            /*
            int foundIndex = Array.IndexOf(MyArray, elementToRemove);

            if (foundIndex != -1)
            {
                for (int i = foundIndex; i < Index - 1; i++)
                {
                    MyArray[i] = MyArray[i + 1];
                }
                MyArray[Index - 1] = default(T);
                Index--;
            }
            else
            {
                Console.WriteLine("Item not found");

            }
            */
        }




    }


}
