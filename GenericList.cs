using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_HomeWork_2._1
{
    //mplement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
    //clearing the list, finding element by its value and ToString()
    public class GenericList<T>
    {
        private T[] data = null;
        private int size;

        public GenericList(int size)
        {
            this.data = new T[size];
        }

        public void Add(T item)
        {
            this.data[this.size++] = item;
        }

        public T GetItem(int index)
        {
            return this.data[index];
        }

        public void RemoveAt(int index)
        {

        }

        public void InsertAt(T item, int index)
        {
            this.data[index] = item;
        }

        public void Clear()
        {

        }

        public int Find(T item)
        {
            return 1;
        }

        public override string ToString()
        {
            return String.Join(", ", data); ;
        }
    }
}
