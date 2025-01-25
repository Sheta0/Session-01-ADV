using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class Range<T> where T : IComparable<T>, INumber<T>
    {
        public T MinValue { get; set; }
        public T MaxValue { get; set; }

        public Range(T _minValue, T _maxValue)
        {
            MinValue = _minValue;
            MaxValue = _maxValue;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(MinValue) >= 0 && value.CompareTo(MaxValue) <= 0 ;
        }
        public T Length()
        {
            return MaxValue - MinValue;
        }
    }
    
}
