using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    internal static class Helper/*<T> where T : class*//*, IComparable<T>*//*, new()*/
    #region Generic Constraints
    // Generic Type Constraint
    // 1. Primary Constraint [0 or 1]
        // General primary constraint => class or struct or enum or notnull  
        // Special primary constraint => Employee or Point (user defined)
            // ==> class or any class inherit from class
            // ==> class must be not sealed


    // 2. Secondary Constraint [0 or many]
    // Interface Constraint => IClonable, IComparable<T>, IComparable, IEquatable<T>, IEquatable

    // 3. Constructor Constraint
    // new() ==> parameterless constructor (for class only) 
    #endregion
    {
        #region Non Generic Swap
        //public static void Swap(ref int X, ref int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        //public static void Swap(ref double X, ref double Y)
        //{
        //    double temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        //public static void Swap(ref Point X, ref Point Y)
        //{
        //    Point temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        #endregion

        #region Generic Swap
        // Generic Swap method
        public static void Swap<T1>(ref T1 X, ref T1 Y)
        {
            T1 temp = X;
            X = Y;
            Y = temp;
        }
        #endregion

        #region Generic Search Array
        public static int SearchArray<T>(T[] arr, T value)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(value)) // Equals => struct : compares object states, class : compares object references
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static int SearchArray<T>(T[] arr, T value, IEqualityComparer<T> equalityComparer)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (equalityComparer.Equals(arr[i], value)) // Equals => struct : compares object states, class : compares object references
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


        #endregion

        #region Bubble Sort
        // Constraints has two levels
        // 1. Generic Contraint on class level
        // 2. Generic Constraint on method level
        public static void BubbleSort<T1>(T1[] arr) where T1 : IComparable<T1>
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        public static void BubbleSort<T1>(T1[] arr, IComparer<T1> comparer) where T1 : IComparable<T1>
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (comparer.Compare(arr[j], arr[j+1]) > 0)
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        #endregion

        public static void PrintArray<T>(T[] arr)
        {
            if (arr is not null)
            {
                foreach (T i in arr)
                {
                    Console.WriteLine($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}