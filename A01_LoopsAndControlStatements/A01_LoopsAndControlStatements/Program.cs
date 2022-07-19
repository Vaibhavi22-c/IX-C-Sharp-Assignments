using System;

namespace A1_LoopsAndControlStatements
{
    class Program
    {
        public static void Main()
        {
            int i;
            Console.WriteLine("Enter Number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered number "+i+"\n");
            
            //if else
            if (i == 0)
            {
                Console.WriteLine("Number is Zero\n");
            }
            else if (i > 0)
            {
                Console.WriteLine("Number is Positive\n");
            }
            else
            {
                Console.WriteLine("Number is Negative\n");
            }
            
            //switch case
            if (i > 0)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("1 in Roman Numerals is I\n");
                        break;
                    case 5:
                        Console.WriteLine("5 in Roman Numerals is V\n");
                        break;
                    case 10:
                        Console.WriteLine("10 in Roman Numerals is X\n");
                        break;
                    case 50:
                        Console.WriteLine("50 in Roman Numerals is L\n");
                        break;
                    case 100:
                        Console.WriteLine("100 in Roman Numerals is C\n");
                        break;
                    case 500:
                        Console.WriteLine("500 in Roman Numerals is D\n");
                        break;
                    case 1000:
                        Console.WriteLine("1000 in Roman Numerals is M\n");
                        break;
                    default:
                        Console.WriteLine("Other number than 1,5,10,50,100,500,1000\n");
                        break;
                }
            }

            //loops
            int sum = 0;
            int j = 0;
            if (i > 0)
            {
                //while
                while (j <= i)
                {
                    sum += j;
                    j++;
                }
                Console.WriteLine("Sum of first " + i + " numbers is " + sum+"\n");
                
                // do while
                j = i;
                Console.WriteLine("The reverse of number is :");
                do
                {
                    Console.Write(j % 10);
                    j /= 10;
                } while (j > 0);

                //for
                Console.WriteLine("\n\nFirst " + i + " numbers in reverse order");
                for (j = i; j > 0; j--)
                {
                    Console.Write(" "+j);
                }
            }

            //foreach
            string[] numberSystems = { "Binary", "Decimal", "Octal", "Hexadecimal" };
            Console.WriteLine("\n\nTypes of Number Systems are:");
            foreach (string numberSystem in numberSystems)
            {
                Console.WriteLine(numberSystem);
            }
        }
    }
}
