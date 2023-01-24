using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HW1();
        }
        static void HW1()
        {
            Console.WriteLine("Enter numbers 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter numbers 2: ");
            int num2 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter numbers 3: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= -5 && num1 <= 5)
            {
                Console.WriteLine("Number 1 is in the rage [-5;5]");
            }
            else
            {
                Console.WriteLine("Number 1 isn't in the rage [-5;5]");
            }

            if (num2 >= -5 && num2 <= 5)
            {
                Console.WriteLine("Number 2 is in the rage [-5;5]");
            }
            else
            {
                Console.WriteLine("Number 2 isn't in the rage [-5;5]");
            }

            if (num3 >= -5 && num3 <= 5)
            {
                Console.WriteLine("Number 3 is in the rage [-5;5]");
            }
            else
            {
                Console.WriteLine("Number 3 isn't in the rage [-5;5]");
            }
            Console.ReadLine();
        }

        static void HW2()
        {
            int[] myArray = { 0, 0, 0 };

            Console.WriteLine("Enter first nubmer: ");
            myArray[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second nubmer: ");
            myArray[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third nubmer: ");
            myArray[2] = int.Parse(Console.ReadLine());

            int minValue = myArray[0];
            int maxValue = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
            for (int j = 1; j < myArray.Length; j++)
            {
                if (myArray[j] > maxValue)
                {
                    maxValue = myArray[j];
                }
            }
            Console.WriteLine("Min: " + minValue);
            Console.WriteLine("Max: " + maxValue);
            Console.ReadLine();

        }
        enum HTTPError
        {
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404
        }
        static void HW3()
        {
            Console.Write("Write a namber (400-404): ");
            int error = int.Parse(Console.ReadLine());
            switch (error)
            {
                case (int)HTTPError.Bad_Request: Console.WriteLine(HTTPError.Bad_Request);
                    break;
                case (int)HTTPError.Unauthorized:
                    Console.WriteLine(HTTPError.Unauthorized);
                    break;
                case (int)HTTPError.Payment_Required:
                    Console.WriteLine(HTTPError.Payment_Required);
                    break;
                case (int)HTTPError.Forbidden:
                    Console.WriteLine(HTTPError.Forbidden);
                    break;
                case (int)HTTPError.Not_Found:
                    Console.WriteLine(HTTPError.Not_Found);
                    break;


            }
        }


        public struct Dog
        {
            public string name;
            public string mark;
            public int age; 
            public override string ToString()
            {
                return "Name dog's: " + name + ". " + "Mark dog's: " + mark + ". " + "Age dog's: " + age+ ". ";
            }
        }
        static void HW4()
        {
            Console.WriteLine("Enter the name Dog's: ");
            string nameDog = Console.ReadLine();
            Console.WriteLine("Enter the mark Dog's: ");
            string markDog = Console.ReadLine();
            Console.WriteLine("Enter the age Dog's: ");
            int ageDog = int.Parse(Console.ReadLine());

            Dog myDog = new Dog { age = ageDog, mark = markDog, name = nameDog };

            Console.WriteLine(myDog.ToString());
        }
    }
}
