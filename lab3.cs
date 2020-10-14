using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1 and 2 polimorf: ");
            Cow cow1 = new Cow();
            cow1.getName();
            Whale whale1 = new Whale();
            whale1.getName();
            Console.ReadLine();
            Console.WriteLine("Zadanie 3 polimorf: ");
            cat cat1 = new cat();
            dog dog1 = new dog();
            bird bird = new bird();
            lamp lamp = new lamp();
            NameOfObj(cat1);
            NameOfObj(dog1);
            NameOfObj(bird);
            NameOfObj(lamp);
            Console.ReadLine();
            Console.WriteLine("Zadanie 4 polimorf:");
            cat cat = new cat();
            Console.WriteLine($"Кошка создала - {cat.GetChild()}");
            dog dog = new dog();
            Console.WriteLine($"Собака создала - {dog.GetChild()}");
            Console.ReadLine();
            Console.WriteLine("Zadanie 1 peregruz:");
            Print(3);
            Print("текст");
            Console.ReadLine();
            Console.WriteLine("Zadanie 2 peregruz:");
            Print(4);
            Print((Int16)32767);
            Console.ReadLine();
            Console.WriteLine("Zadanie 3 peregruz:");
            Print(4);
            Print((Int16)32767);
            Print("текст");
            Print(0.3);
            Print((byte)2);
            Console.ReadLine();
            Console.WriteLine("Zadanie 4 peregruz:");
            Min(4, 5);
            Min((long)8, (long)5);
            Min(0.2, 0.6);
            Console.ReadLine();
            Console.WriteLine("Zadanie 5 peregruz:");
            Max(9, 2);
            Max((long)55, (long)99);
            Max(0.55, 0.99);
            Console.ReadLine();
        }

        public static void NameOfObj(object obj) 
        {
            if (obj is dog) {
                Console.WriteLine("Это собака");
            }
            if (obj is cat)
            {
                Console.WriteLine("Это кошка");
            }
            if (obj is bird)
            {
                Console.WriteLine("Это птица");
            }
            if (obj is lamp)
            {
                Console.WriteLine("Это лампа");
            }
        }
        public static void Print(int number)
        {
            Console.WriteLine($"int : {number}");
        }
        public static void Print(string message)
        {
            Console.WriteLine($"string : {message}");
        }
        public static void Print(Int16 number)
        {
            Console.WriteLine($"int16: {number}");
        }

        public static void Print(double number)
        {
            Console.WriteLine($"double : {number}");
        }

        public static void Print(byte number)
        {
            {
                Console.WriteLine($"byte : {number}");
            }
        }

        public static void Min(int number1, int number2)
        {
            int min;
            if (number1 < number2)
                min = number1;
            else min = number2;
            Console.WriteLine($"int min: {min}");
        }
        public static void Min(long number1, long number2)
        {
            long min;
            if (number1 < number2)
                min = number1;
            else min = number2;
            Console.WriteLine($"long min: {min}");
        }
        public static void Min(double number1, double number2)
        {
            double min;
            if (number1 < number2)
                min = number1;
            else min = number2;
            Console.WriteLine($"double min: {min}");
        }

        public static void Max(int number1, int number2)
        {
            int max;
            if (number1 > number2)
                max = number1;
            else max = number2;
            Console.WriteLine($"int max: {max}");
        }
        public static void Max(long number1, long number2)
        {
            long max;
            if (number1 > number2)
                max = number1;
            else max = number2;
            Console.WriteLine($"long max: {max}");
        }
        public static void Max(double number1, double number2)
        {
            double max;
            if (number1 > number2)
                max = number1;
            else max = number2;
            Console.WriteLine($"double max: {max}");
        }
        
    }
    public class Cow
    {

        public virtual void getName()
        {
            Console.WriteLine("Я корова");
        }
    }
    public class Whale : Cow
    {
        public override void getName()
        {
            Console.WriteLine("Я не корова, я -  кит");
        }
    }
    public class cat
    {
        public virtual string GetChild()
        {
            return "котенок";
        }

    }
    public class dog
    {
        public virtual string GetChild()
        {
            return "щенок";
        }

    }
    public class bird { }
    public class lamp { }
}
