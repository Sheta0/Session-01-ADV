using System.Collections;

namespace Demo_01
{
    internal class Program
    {
        public static int? ArrayListSum(ArrayList arrayList)
        {
            if (arrayList is null) return 0;
            int? sum = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                sum += (int?)arrayList[i]; // Unboxing
            }
            return sum ?? 0;
        }
        public static int? ListSum(List<int> list)
        {
            if (list is null) return 0;
            int? sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum ?? 0;
        }
        static void Main(string[] args)
        {
            // Generics : 
            // C# Feature 2005 C# 2.0
            // let you write a class or method that can work with any data type

            #region Non Generic Swap
            //int A = 3, B = 5;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //Console.WriteLine("========= After Swap =========");

            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");


            //double K = 3.14, L = 2.71;
            //Console.WriteLine($"K = {K}");
            //Console.WriteLine($"L = {L}");

            //Console.WriteLine("========= After Swap =========");

            //Helper.Swap(ref K, ref L);
            //Console.WriteLine($"K = {K}");
            //Console.WriteLine($"L = {L}");


            //Point P01 = new Point(3, 5);
            //Point P02 = new Point(7, 11);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");

            //Console.WriteLine("========= After Swap =========");

            //Helper.Swap(ref P01, ref P02);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");
            #endregion

            #region Generic Swap
            //int A = 3, B = 5;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //Console.WriteLine("========= After Swap =========");

            //Helper/*<int>*/.Swap(ref A, ref B);
            //// In case Generic Type "T" is declared on Method level not class/interface/struct level
            //// Compiler can detect the type of "T" based on the type of the Input Parameters
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");



            //double K = 3.14, L = 2.71;
            //Console.WriteLine($"K = {K}");
            //Console.WriteLine($"L = {L}");

            //Console.WriteLine("========= After Swap =========");

            //Helper.Swap(ref K, ref L);
            //Console.WriteLine($"K = {K}");
            //Console.WriteLine($"L = {L}");



            //Point P01 = new Point(3, 5);
            //Point P02 = new Point(7, 11);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");
            //Helper.Swap(ref P01, ref P02);

            //Console.WriteLine("========= After Swap =========");

            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");
            #endregion

            #region Generic Search Array
            // Linear Search
            // 2 9 4 7 1 5 3 6 8
            // Index

            //int[] numbers = { 2, 9, 4, 7, 1, 5, 3, 6, 8 };
            //int index = Helper.SearchArray(numbers, 4);
            //Console.WriteLine($"Index = {index}");


            //Employee[] employees = new Employee[]
            //{
            //    new Employee { Id = 101, Name = "Ahmed", Age = 37, Salary = 5_000 },
            //    new Employee { Id = 102, Name = "Mohamed", Age = 23, Salary = 6_000 },
            //    new Employee { Id = 103, Name = "Ali", Age = 25, Salary = 5_500 }
            //};
            //Employee emp = new Employee { Id = 103, Name = "Ali", Salary = 5_500 };
            //int index = Helper.SearchArray(employees, emp);
            //Console.WriteLine(index);

            ////Employee emp2 = new Employee { Id = 102, Name = "Mohamed", Salary = 6_000 };
            ////Employee emp3 = new Employee { Id = 102, Name = "Mohamed", Salary = 6_000 };
            ////if (emp2 == emp3) // struct does not include "==" operator by default
            ////{
            ////    Console.WriteLine("Equal");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Not Equal");
            ////} 
            #endregion

            #region Equality in struct and class 
            //// Equals => struct => value type : Object => compares object states
            //// ==     => struct => not implemented by default
            //// Equals => class : Object => compares object references
            //// ==     => class : Object => compares object references
            //Employee emp1 = new Employee { Id = 5_000, Name = "Ahmed", Age = 21, Salary = 101 };
            //Employee emp2 = new Employee { Id = 101, Name = "Ahmed", Age = 21, Salary = 5_000 };
            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());

            //if (emp1.Equals(emp2))
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            #endregion

            #region Bubble Sort

            //int[] Numbers = new int[] { 5, 3, 7, 1, 9, 2, 8, 4, 6 };
            //Helper.PrintArray(Numbers);
            //Helper.BubbleSort(Numbers); // Sorting Ascending
            //Helper.PrintArray(Numbers);



            //Point[] points = new Point[]
            //{
            //    new Point(1, 5),
            //    new Point(7, 11),
            //    new Point(1, 2),
            //    new Point(4, 6),
            //    new Point(9, 8)
            //};

            //Helper.PrintArray(points);
            //Helper.BubbleSort(points);
            //Helper.PrintArray(points);



            //Employee emp1 = new Employee { Id = 101, Name = "Haerin", Age = 19, Salary = 10_000 };
            //Employee emp2 = new Employee { Id = 102, Name = "Mohamed", Age = 25, Salary = 12_000 };
            //Employee emp3 = new Employee { Id = 103, Name = "Ali", Age = 21, Salary = 5_500 };

            //Employee[] employees = new Employee[] { emp1, emp2, emp3 };
            //Helper.PrintArray(employees);
            //Helper.BubbleSort(employees);
            //Helper.PrintArray(employees);


            #endregion

            #region is And as Casting Operators

            //Point[] points = new Point[]
            //{
            //    new Point(1, 5),
            //    new Point(7, 11),
            //    new Point(1, 2),
            //    new Point(4, 6),
            //    new Point(9, 8)
            //};

            //Helper.PrintArray(points);
            //Helper.BubbleSort(points);
            //Helper.PrintArray(points);

            //Point P01 = new Point(1, 5);
            //Point P02 = new Point(7, 11);

            //if(P01.CompareTo(P02) > 0)
            //{
            //    Console.WriteLine("P01 > P02");
            //}
            //else if (P01.CompareTo(P02) < 0)
            //{
            //    Console.WriteLine("P01 < P02");
            //}
            //else
            //{
            //    Console.WriteLine("P01 = P02");
            //}

            #endregion

            #region Generic IComparable
            //Employee emp1 = new Employee { Id = 101, Name = "Haerin", Age = 19, Salary = 10_000 };
            //Employee emp2 = new Employee { Id = 102, Name = "Mohamed", Age = 25, Salary = 12_000 };
            //Employee emp3 = new Employee { Id = 103, Name = "Ali", Age = 21, Salary = 5_500 };

            //Employee[] employees = new Employee[] { emp1, emp2, emp3 };
            //Helper.PrintArray(employees);
            //Helper.BubbleSort(employees);
            //Helper.PrintArray(employees);
            #endregion

            #region Built-in Generic Interface IEquatable
            //Employee E01 = new Employee { Id = 101, Name = "Haerin", Age = 19, Salary = 10_000 };
            //Employee E02 = new Employee { Id = 102, Name = "Mohamed", Age = 25, Salary = 12_000 };
            //Employee E03 = new Employee { Id = 103, Name = "Ali", Age = 21, Salary = 5_500 };

            //Employee[] employees = new Employee[] { E01, E02, E03 };

            ////int index = Helper.SearchArray(employees, E02);
            ////Console.WriteLine(index);

            //if(E01.Equals(E02))
            //    Console.WriteLine("E01 == E02");
            //else
            //    Console.WriteLine("E01 != E02"); 
            #endregion

            #region Built-in Generic Interface IEqualityComparer

            //Employee E01 = new Employee { Id = 101, Name = "Haerin", Age = 19, Salary = 10_000 };
            //Employee E02 = new Employee { Id = 102, Name = "Mohamed", Age = 25, Salary = 12_000 };
            //Employee E03 = new Employee { Id = 103, Name = "Ali", Age = 21, Salary = 5_500 };

            //Employee[] employees = new Employee[] { E01, E02, E03 };

            //int index = Helper.SearchArray(employees, new Employee() { Name = "Haerin"}, new EmployeeEqualityComparerName());
            //Console.WriteLine(index);

            #endregion

            #region IComparer with BubbleSort
            //Employee emp1 = new Employee { Id = 101, Name = "Haerin", Age = 19, Salary = 10_000 };
            //Employee emp2 = new Employee { Id = 102, Name = "xy", Age = 25, Salary = 12_000 };
            //Employee emp3 = new Employee { Id = 103, Name = "Ali", Age = 21, Salary = 5_500 };

            //Employee[] employees = new Employee[] { emp1, emp2, emp3 };
            //Helper.PrintArray(employees);
            ////Helper.BubbleSort(employees, new EmployeeComparerSalary()); // Sorting based on salary
            //Helper.BubbleSort(employees, new EmployeeComparerNameLength()); // Sorting based on name length
            //Helper.PrintArray(employees); 
            #endregion

            #region Generic Constraints

            #endregion
        }
    }
}
