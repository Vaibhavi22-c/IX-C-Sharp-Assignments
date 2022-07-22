using System;
using System.Collections;
using System.Collections.Generic;

namespace A3_Hashtable
{
     class Program
    {
      
        static void Main()
        {
            HashtableDemo demo = new HashtableDemo();
            Console.WriteLine("------------Hashtable-------------");
            demo.HashtableOperations();
            Console.WriteLine("\n\n--------------Stack---------------");
            StackDemo sdemo = new StackDemo();
            sdemo.StackOperations();
            Console.WriteLine("\n\n---------------Queue--------------");
            QueueDemo qdemo = new QueueDemo();
            qdemo.QueueOperations();
        }
    }
    class HashtableDemo
    {
        public void HashtableOperations()
        {
            Hashtable address = new Hashtable();
            address.Add("Area", "Katraj");
            address.Add("City", "Pune");
            address.Add("State", "Maharashtra");
            address.Add("Country", "India");
            address.Add("Postalcode", "411046");
            address.Add("Zipcode", "123456");
            foreach (var i in address.Keys)
            {
                Console.WriteLine(i + "   " + address[i]);
            }
            //remove and containsValue
            Console.WriteLine("\nRemove 123456 from hashtable\n");
            address.Remove("Zipcode");
            Console.WriteLine("\nCheck whether 123456 is present in hashtable");
            if (!address.ContainsValue("123456"))
            {
                Console.WriteLine("123456 not found");
            }
            //add record using indexer
            Console.WriteLine("\nAdd zipcode 123456 to hashtable");
            address["Zipcode"] = "123456";
            foreach (var i in address.Keys)
            {
                Console.WriteLine(i + "   " + address[i]);
            }
            //update record using indexer
            Console.WriteLine("\nUpdate postalcode to 411043 ");
            address["Postalcode"] = "411043";
            foreach (var i in address.Keys)
            {
                Console.WriteLine(i + "   " + address[i]);
            }
            //clear
            address.Clear();
            Console.WriteLine("\nHahtable is empty now");
            foreach (var i in address.Keys)
            {
                Console.WriteLine(i + "   " + address[i]);
            }
        }

    }
    class StackDemo
    {
        public void StackOperations()
        {
            // Creates and initializes a new Stack.
            Stack numbers = new Stack();
            numbers.Push("One");
            numbers.Push("Two");
            numbers.Push("Three");
            numbers.Push("Four");
            numbers.Push("Five");
            numbers.Push("Six");
            // Display the Stack.
            Console.Write("\nStack Elements");
            foreach (var i in numbers)
            {
                Console.Write("\t" + i);
            }
            //Remove element from stack
            Console.WriteLine("\n\nRemove one element from stack");
            numbers.Pop();
            foreach (var i in numbers)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine("\n\nTop element of stack.");
            Console.WriteLine("Peek element " + numbers.Peek());
            //contains
            Console.WriteLine("\nCheck whether seven exists in stack ");
            if (numbers.Contains("Seven"))
            {
                Console.WriteLine("Seven exists");
            }
            else
            {
                Console.WriteLine("Seven does not exists");
            }
            //clone
            Console.WriteLine("\nCloned stack");
            Stack clonedStack = (Stack)numbers.Clone();
            foreach (var i in clonedStack)
            {
                Console.WriteLine("\t" + i);
            }

        }
    }
    class QueueDemo
    {
        public void QueueOperations()
        {
            Queue<string> queueOfNumbers = new Queue<string>();
            queueOfNumbers.Enqueue("One");
            queueOfNumbers.Enqueue("Two");
            queueOfNumbers.Enqueue("Three");
            queueOfNumbers.Enqueue("Four");
            queueOfNumbers.Enqueue("Five");
            queueOfNumbers.Enqueue("Six");
            // Display the Queue.
            Console.Write("\nQueue Elements\n");
            foreach (var i in queueOfNumbers)
            {
                Console.Write("\t" + i);
            }
            //Remove element from queue
            Console.WriteLine("\n\nRemove one element from queue");
            queueOfNumbers.Dequeue();
            foreach (var i in queueOfNumbers)
            {
                Console.Write("\t" + i);
            }
            //Top Element
            Console.WriteLine("\n\nTop element of queue.");
            Console.WriteLine("Peek element " + queueOfNumbers.Peek());
            //contains
            Console.WriteLine("\nCheck whether six exists in queue ");
            if (queueOfNumbers.Contains("Six"))
            {
                Console.WriteLine("Six exists");
            }
            else
            {
                Console.WriteLine("Six does not exists");
            }
            //clear
            queueOfNumbers.Clear();
            Console.WriteLine("\nQueue is empty now");
            foreach (var j in queueOfNumbers)
            {
                Console.WriteLine(j);
            }
        }
    }
}
