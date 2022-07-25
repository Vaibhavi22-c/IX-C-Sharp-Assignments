using System;
using System.Collections.Generic;

namespace A05_GenericCollections
{
    internal class GenericCollections
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----------------List------------------");
            ListDemo ldemo = new ListDemo();
            ldemo.ListOperations();
            Console.WriteLine("\n-----------------Stack------------------");
            StackDemo sdemo = new StackDemo(); 
            sdemo.StackOperations();
            Console.WriteLine("\n-----------------Queue------------------");
            QueueDemo qdemo = new QueueDemo();
            qdemo.QueueOperations();
            Console.WriteLine("\n-----------------Dictionary------------------");
            DictionaryDemo ddemo = new DictionaryDemo();
            ddemo.DictionaryOperations();
            Console.WriteLine("\n-----------------SortedList------------------");
            SortedListDemo sldemo = new SortedListDemo();
            sldemo.SortedListOperations();
        }
    }
    class ListDemo
    {
        class Mathematicians //Implementaion of list using object
        {
            public int Id { get; set; }
            public string name { get; set; }
            public string invention { get; set; }
        }
       public void ListOperations()
        {
            //List implementation using object
            Mathematicians mathematician1 = new Mathematicians()
            {
                Id = 1,
                name = "AryaBhata",
                invention = "Earth's spherical shape",
            };
            Mathematicians mathematician2 = new Mathematicians()
            {
                Id = 2,
                name = "Varahamihira",
                invention = "Pascal's Triangle"
            };
            Mathematicians mathematician3 = new Mathematicians()
            {
                Id = 3,
                name = "Brahmagupta",
                invention="zero"
            };
            List<Mathematicians> mathematiciansList = new List<Mathematicians>();
            mathematiciansList.Add(mathematician1);
            mathematiciansList.Add(mathematician2);
            mathematiciansList.Add(mathematician3);
            //print list
            Console.WriteLine("\nMathematicians List:");
            foreach(Mathematicians mathematicians in mathematiciansList)
            {
                Console.WriteLine("ID={0},\t Mathematician Name = {1},\t Invention = {2}", mathematicians.Id, mathematicians.name, mathematicians.invention);
            }
            //List implementation without using object
            //create list and add elements
            List<int> oddNumbers = new List<int>();
            oddNumbers.Add(1); // adding elements using add() method
            oddNumbers.Add(3);
            oddNumbers.Add(5);
            oddNumbers.Add(7);
            oddNumbers.Add(8);
            //print list
            Console.WriteLine("\nOdd numbers list:");
            foreach (int i in oddNumbers)
            {
                Console.WriteLine("\t" + i);
            }
            //remove and contains
            Console.WriteLine("\nRemove 8 from list as it is not an odd number");
            oddNumbers.Remove(8);
            if (oddNumbers.Contains(8))
            {
                Console.WriteLine("\n8 is in the list.");
            }
            else
            {
                Console.WriteLine("\n8 is not in the list.");
            }
        }
    }
    class StackDemo
    {
        public void StackOperations()
        {
            //create and add elements on the stack
            Stack<int> oddNumbers = new Stack<int>();
            oddNumbers.Push(1);
            oddNumbers.Push(3);
            oddNumbers.Push(5);
            oddNumbers.Push(7);
            //print the stack
            foreach (var number in oddNumbers)
            {
                Console.Write(number + " ");
            }
            //count
            Console.WriteLine("\nTotal elements in stack are : " + oddNumbers.Count);
            //peek element
            Console.WriteLine("\nPeek element of stack: " + oddNumbers.Peek());
            //pop
            Console.WriteLine("\nRemove(pop) element from stack ");
            var temp = oddNumbers.Pop();
            //contains
            Console.WriteLine("\nCheck whether removed element " + temp + " is in the stack");
            if (oddNumbers.Contains(temp))
            {
                Console.WriteLine("\n" + temp + " is in the stack");
            }
            else
            {
                Console.WriteLine("\n" + temp + " is not in the stack");
            }
        }
    }
    class QueueDemo
    {
        public void QueueOperations()
        {
            //create and add elements in the queue
            Queue<int> evenNumbers = new Queue<int>();
            evenNumbers.Enqueue(2);
            evenNumbers.Enqueue(4);
            evenNumbers.Enqueue(6);
            evenNumbers.Enqueue(8);
            evenNumbers.Enqueue(9);
            //print queue
            foreach (var number in evenNumbers)
                Console.Write(number);
            //count
            Console.WriteLine("\nTotal elements in the queue are : " + evenNumbers.Count);
            //peek element
            Console.WriteLine("\nPeek element of the queue: " + evenNumbers.Peek());
            //pop
            Console.WriteLine("\nRemove(dequeue) element from stack ");
            var temp = evenNumbers.Dequeue();
            //contains
            Console.WriteLine("\nCheck whether removed element " + temp + " is in the queue");
            if (evenNumbers.Contains(temp))
            {
                Console.WriteLine("\n" + temp + " is in the queue");
            }
            else
            {
                Console.WriteLine("\n" + temp + " is not in the queue");
            }
        }
    }
    class DictionaryDemo
    {
        public void DictionaryOperations()
        {
            Dictionary<string, string> address = new Dictionary<string, string>();
            // Adding key/value pairs in the Dictionary using Add() method
            address.Add("pincode", "411046");
            address.Add("zipcode", "12345");
            address.Add("Area", "Katraj");
            address.Add("City", "Pune");
            address.Add("State", "Maharashtra");
            address.Add("Country", "India");
            //print 
            foreach(KeyValuePair<string,string> element in address)
            {
                Console.WriteLine(element.Key+"  "+element.Value);
            }
            //update
            address["pincode"] = "411043";
            if (address.ContainsKey("pincode"))
            {
                Console.WriteLine("\n key:pincode value:{0}", address["pincode"]);
            }
            //remove
            Console.WriteLine("\nRemove zipcode");
            address.Remove("zipcode");
            if(address.ContainsKey("zipcode"))
            {
                Console.WriteLine("\nDictionary contains zipcode");
            }
            else
            {
                Console.WriteLine("\nDictionary does not contains zipcode");
            }
            //clear 
            address.Clear();
        }
    }
    class SortedListDemo
    {
        public void SortedListOperations()
        {
            //SortedList of int keys, string values 
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(1, "One");
            numberNames.Add(5, "Five");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "Four");
            numberNames.Add(3, null);
            numberNames.Add(10, "Ten");
            //print
            foreach (KeyValuePair<int, string> num in numberNames)
            {
                Console.WriteLine(num);
            }
            //remove and contains
            numberNames.Remove(3);
            if (numberNames.ContainsKey(3))
            {
                Console.WriteLine("\nSortedList contains 3");
            }
            else
            {
                Console.WriteLine("\nSortedList does not contains 3");
            }
        }
    }
}