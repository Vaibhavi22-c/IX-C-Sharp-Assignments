using System;

namespace A04_ArraySortUsingArrayParameter
{
    class ArrayOperations
    {
        public int[] ArraySort(int[] parameterArray)
        {
            Array.Sort(parameterArray);
            return parameterArray;
        }
        public int[] ArrayReverse(int[] parameterArray)
        {
            Array.Reverse(parameterArray);
            return parameterArray;
        }
        public void ArrayElementExists(int[] parameterArray)
        {
            int temp;
            Console.WriteLine("\nEnter the number to search in array");
            temp = Convert.ToInt32(Console.ReadLine());
            if (Array.Exists(parameterArray, element => element.Equals(temp)))
            {
                Console.WriteLine("\n" + temp + " exists");
            }
            else
            {
                Console.WriteLine("\n" + temp + " does not exists");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            int n,i;
            //Number of elements in array
            Console.WriteLine("\nPlease enter the number of elements in the array");
            n = Convert.ToInt32(Console.ReadLine());
            //Accepting array as a input from user
            int[] numbers = new int[n];
            Console.Write("Input "+ n + " elements in the array :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("Element "+(i+1)+": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Printing array
            Console.Write("\nElements in array are: ");
            for (i = 0; i < n; i++)
            {
                 Console.Write("\t"+numbers[i]);
            }
            ArrayOperations arrayOperation = new ArrayOperations();
            string choice;
            Console.WriteLine("\n\nPlease enter your choice\n1)\"sort\" for sorting array\n2)\"reverse\" for reversing arrray\n3)\"exists\" to check whether element exists in array.\n4)\"all\" for executing all operations.\n5)\"exit\" for terminating program");
            choice=Console.ReadLine();
            switch(choice)
            {
                case "sort": //ArraySort
                    arrayOperation.ArraySort(numbers);
                    Console.WriteLine("\nArray after sorting");
                    foreach (var number in numbers)
                    {
                        Console.WriteLine("\t" + number);
                    }
                    break;
                case "reverse": //Reverse the array
                    arrayOperation.ArrayReverse(numbers);
                    Console.WriteLine("\nArray after reversing");
                    foreach (var number in numbers)
                    {
                        Console.WriteLine("\t" + number);
                    }
                    break;
                case "exists"://Check whether element exists in array
                    arrayOperation.ArrayElementExists(numbers);
                    break;
                case "all"://Execute all operations
                    //ArraySort
                    arrayOperation.ArraySort(numbers);
                    Console.WriteLine("\nArray after sorting");
                    foreach (var number in numbers)
                    {
                        Console.WriteLine("\t" + number);
                    }
                    //Reverse the array
                    arrayOperation.ArrayReverse(numbers);
                    Console.WriteLine("\nArray after reversing");
                    foreach (var number in numbers)
                    {
                        Console.WriteLine("\t" + number);
                    }
                    //Check whether element exists in array
                    arrayOperation.ArrayElementExists(numbers);
                    break;
                case "exit"://Exit
                    Console.WriteLine("\nNo operation selected");
                    return;
            }
        }
    }
}

