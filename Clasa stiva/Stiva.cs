using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clasa_stiva
{
    class Stiva<T>
    {
        private T[] data;
        private int length = 0;
        public Stiva()
        {
            data = new T[100];
        }

        public Stiva(int n)
        {
            data = new T[n];
        }

        public void Push(T newElement)
        {
            if (length < data.Length)
            {
                data[length++] = newElement;
            }
            else
            {
                throw new Exception("Stiva este plina");
            }
        }

        public T Pop()
        {
            if (length != 0)
            {
                length--;
                return data[length];
            }
            else
            {
                throw new Exception("Stiva este goala");
            }
        }

        public void Clear()
        {
            data = new T[data.Length];
            length = 0;
        }
    }
}
