using System;
using System.Collections;

namespace A2_ArrayAndArrayList
{
    internal class Program
    {
        static void Main()
        {
            string[] employees = { "Manva", "Netra", "Vihan", "Sana", "Aditi", "Vishal", "Samar" };
            //Array Length
            Console.WriteLine("Array is of length : " + employees.Length);
            //Array Sorting
            Console.WriteLine("\nArray before sorting :");
            foreach (string employee in employees)
            {
                Console.WriteLine(employee);    
            }
            Array.Sort(employees);
            Console.WriteLine("\nArray after sorting :");
            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }
            //Array Reversal
            Array.Reverse(employees);
            Console.WriteLine("\nArray Reversed :");
            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("\n--------ArrayList--------");
            //ArrayList
            var employeeDetails = new ArrayList();
            employeeDetails.Add(1);
            employeeDetails.Add("Vidya");
            employeeDetails.Add(25000);
            employeeDetails.Add("Robotics");
            Console.WriteLine("\nArrayList is :");
            foreach(var employee in employeeDetails)
            {
                Console.WriteLine(employee);
            }
            //Add
            Console.WriteLine("\nManav added in ArrayList");
            employeeDetails.Add("Manav");
            foreach (var employee in employeeDetails)
            {
                Console.WriteLine(employee);
            }
            //Remove
            Console.WriteLine("\nManav removed from ArrayList");
            employeeDetails.Remove("Manav");
            foreach (var employee in employeeDetails)
            {
                Console.WriteLine(employee);
            }
            //IndexOf
            Console.WriteLine("\nIndex of Robotics "+ employeeDetails.IndexOf("Robotics"));
            //Contains
            Console.WriteLine("\nCheck whether 101 element exists in arraylist");
            if (employeeDetails.Contains("101"))
                Console.WriteLine("Yes, exists at index " + employeeDetails.IndexOf("101"));
            else
                Console.WriteLine("No,element 101 doesn't exists");
        }
    }
}
