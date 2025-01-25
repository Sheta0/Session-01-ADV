using System.Collections;

namespace Assignment_01
{
    internal class Program
    {
        #region Q1
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        public static void Swap<T1>(ref T1 X, ref T1 Y)
        {
            T1 temp = X;
            X = Y;
            Y = temp;
        }

        public static void PrintArray<T>(T[] arr)
        {
            if (arr is not null)
            {
                foreach (T i in arr)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Q3
        public static void ReverseArrayList(ArrayList arr)
        {
            if (arr is not null)
            {
                int count = arr.Count;
                for (int i = 0; i < count / 2; i++)
                {
                    object temp = arr[i];
                    arr[i] = arr[count - i - 1];
                    arr[count - i - 1] = temp;
                }
            }
        }
        #endregion

        #region Q4
        public static List<int> FindEvenNumbers(List<int> list)
        {
            List<int> evenNumbers = new List<int>();
            if (list is not null)
            {
                foreach (int i in list)
                {
                    if (i % 2 == 0)
                    {
                        evenNumbers.Add(i);
                    }
                }
            }
            return evenNumbers;
        }
        #endregion

        #region Q6
        public static int FirstNonRepeatedCharacterIndex(string str)
        {
            if (string.IsNullOrEmpty(str)) return -1;

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (charCount.ContainsKey(char.ToUpper(str[i])))
                {
                    charCount[char.ToUpper(str[i])]++;
                }
                else
                {
                    charCount[char.ToUpper(str[i])] = 1;
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[char.ToUpper(str[i])] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1
            //int[] array = { 5, 7, 3, 8, 6, 4, 1, 2, 9, 0 };

            //PrintArray(array);
            //BubbleSort(array);
            //Console.WriteLine("===== After Bubble Sort ====");
            //Console.WriteLine();
            //PrintArray(array);
            #endregion

            #region Q2

            //Range<int> R01 = new Range<int>(1, 10);
            //Console.WriteLine(R01.IsInRange(5));
            //Console.WriteLine(R01.IsInRange(15));
            //Console.WriteLine(R01.Length());

            //Range<double> R02 = new Range<double>(7.2, 9.3);
            //Console.WriteLine(R02.IsInRange(7.1));
            //Console.WriteLine(R02.IsInRange(9.2));
            //Console.WriteLine(R02.Length());

            #endregion

            #region Q3
            //ArrayList arr = new ArrayList() { 1, 2, 3 };

            //PrintArray(arr.ToArray());

            //ReverseArrayList(arr);

            //PrintArray(arr.ToArray()); 
            #endregion

            #region Q4
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //PrintArray(list.ToArray());
            //List<int> evenNumbers = FindEvenNumbers(list);
            //PrintArray(evenNumbers.ToArray()); 
            #endregion

            #region Q5
            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(3);

            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(3);

            //Console.WriteLine(fixedSizeList.Get(0));
            //Console.WriteLine(fixedSizeList.Get(1));
            //Console.WriteLine(fixedSizeList.Get(2));

            //try
            //{
            //    fixedSizeList.Add(4);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message); 
            //}

            //try
            //{
            //    Console.WriteLine(fixedSizeList.Get(3));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Q6
            //string testString = "Hanni Pham";
            //int index = FirstNonRepeatedCharacterIndex(testString);
            //Console.WriteLine($"The index of the first non-repeated character in '{testString}' is: {index}");
            #endregion
        }
    }
}