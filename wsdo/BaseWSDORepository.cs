using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.wsdo
{
    class BaseWSDORepository<T>
    {
        public void Delete(T t)
        {

        }

        public T Update(T t)
        {
            return t;
        }

        public T Create(T t)
        {
            return t;
        }

        public T Get(int id)
        {
            return default(T);
        }

        public T[] Search(Object t)
        {
            return default(T[]);
        }
    }
}
