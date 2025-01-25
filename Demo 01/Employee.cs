using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class EmployeeEqualityComparerName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }

    class EmployeeComparerSalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
    
    class EmployeeComparerNameLength : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Name.Length.CompareTo(y.Name.Length);
        }
    }

    internal class Employee : IComparable<Employee>, IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        #region non generic CompareTo
        //public int CompareTo(object? obj)
        //{
        //    ////Employee? E = (Employee?)obj; // unsafe casting

        //    //// Is conditional operator
        //    //// return true => obj is Employee, obj is from class inherit from employee
        //    //// return false => obj is null, obj is not Employee, obj is from class not inherit from employee
        //    //if (obj is Employee employee)
        //    //{
        //    //    return Salary.CompareTo(employee?.Salary);
        //    //}
        //    //return 1;

        //    //// As casting operator
        //    //// Succeed => obj is Employee, obj is from class inherit from employee

        //    Employee? employee = obj as Employee;
        //    return Salary.CompareTo(employee?.Salary);
        //} 
        #endregion
        public int CompareTo(Employee? other)
        {
            return Age.CompareTo(other?.Age);
        }
        #region non generic Equals

        //public override bool Equals(object? obj)
        //{
        //    // Compare object state
        //    Employee? E = (Employee?)obj;
        //    return this == E;
        //} 
        #endregion
        public bool Equals(Employee? other)
        {
            if (other is null) return false;
            return this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Age, Salary);
        }


        public static bool operator ==(Employee left, Employee right)
        {
            return (left.Id == right.Id) && (left.Name == right.Name) && (left.Age == right.Age) && (left.Salary == right.Salary);

        }
        public static bool operator !=(Employee left, Employee right)
        {
            return (left.Id != right.Id) || (left.Name != right.Name) || (left.Age != right.Age) || (left.Salary != right.Salary);
        }
    }
}
