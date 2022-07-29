using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Generics
{
    public class GenericArray<T>
    {
        private T[] array;
        public GenericArray(T[] array)
        {
            this.array = array;
        }

        public T getItem(int index)
        {
            if(index > array.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            return array[index];
        }
        public void setItem(int index, T item)
        {
            if (index > array.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            array[index] = item;
        }
        public void swap(int index1, int index2)
        {
            T aux = array[index1];
            array[index1] = array[index2];
            array[index2] = aux;
        }
        public void swap(int index, T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (item.Equals(array[i]))
                {
                    T aux = array[i];
                    array[i] = array[index];
                    array[index] = aux;
                    break;
                }
            }
        }
        public void swap(T item1, T item2)
        {
            int aux1 = -1;
            int aux2 = -1; ;
            for (int i = 0; i < array.Length; i++)
            {
                if (item1.Equals(array[i]))
                {
                    aux1 = i;
                }
                if (item2.Equals(array[i]))
                {
                    aux2 = i;
                }
            }
            try
            {
                T aux = array[aux1];
                array[aux1] = array[aux2];
                array[aux2] = aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void swap(T item, int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (item.Equals(array[i]))
                {
                    T aux = array[i];
                    array[i] = array[index];
                    array[index] = aux;
                    break;
                }
            }
        }
        public string toString()
        {
            string res="";
            for(int i=0; i< array.Length; i++)
            {
                res += array[i].ToString();
            }
            return res;
        }
    }
}
