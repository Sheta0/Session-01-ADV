using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class FixedSizeList<T>
    {
        public T[] Items { get; private set; }
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public FixedSizeList(int _capacity)
        {
            Capacity = _capacity;
            Items = new T[Capacity];
            Count = 0;
        }

        public void Add(T item)
        {
            if (Count < Capacity)
            {
                Items[Count] = item;
                Count++;
            }
            else
            {
                throw new InvalidOperationException("List is already full");
            }
        }

        public T Get(int index)
        {
            if (index >= 0 && index < Count)
            {
                return Items[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");
            }
        }
    }
}
