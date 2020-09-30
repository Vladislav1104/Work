using System;

namespace Лаба2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            Console.ReadLine();
            Pegas pegas = new Pegas();
            Console.ReadLine();
            Console.WriteLine("Zadanie 2");
            Cat cat  = new Cat();
            cat.CatInformation();
            Console.ReadLine();
            Dog dog = new Dog();
            dog.DogInformation();
            Console.ReadLine();
            Console.WriteLine("Zadanie 3");
            human chel = new human();
            chel.fishInfo();
            chel.aniamalInfo();
            chel.apeInfo();
            chel.humanInfo();
            Console.ReadLine();
            Console.WriteLine("Zadanie 4");
            Cat cat1 = new Cat();
            Console.WriteLine($"Возраст кота: {cat1.CatAge}, вес кота: {cat1.CatWeight}");
            Console.WriteLine("Кот имеет " + cat1.PoluchenieDannih());
            Console.ReadLine();

        }
        class Horse
        {
            protected string name;
            public Horse()
            {
                Console.WriteLine("Введите кличку: ");
                name = Console.ReadLine();
            }
        }
        class Pegas : Horse
        {
            public Pegas()
            {
                Console.WriteLine($"В небе летит лошадь {name}");
            }
        }
        class pet
        {
            protected double weight;
            protected double age;
            protected bool gender;
            protected pet()
            {
                Console.WriteLine("Введите вес: ");
                while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0) Console.WriteLine("Bad type, try again: ");
                Console.WriteLine("Введите возраст: ");
                while (!double.TryParse(Console.ReadLine(), out age) || age < 0) Console.WriteLine("Bad type, try again: ");
                Console.WriteLine("Введите 1 если пол - мужской, или другое если женский.");
                if (Console.ReadLine() == "1") gender = true;
                else gender = false;
                
            }
        }
        class Cat : pet
        {
            private double catWeight;
            public double CatWeight { get { return catWeight; } }
            private double catAge;
            public double CatAge { get { return catAge; } }

            public Cat()
            {
                catAge = age;
                catWeight = weight;
            }
            public string PoluchenieDannih()
            {
                return $"Возраст: {catAge} \n Вес: {catWeight}";
            }
            public void CatInformation()
            {
                if (gender)
                {
                    if (age < 1) Console.Write("Котёнок мужского пола," + $" возрастом - {age}");
                    else if (age < 5) Console.Write("Кот," + $" возрастом - {age}");
                    else Console.Write("Старый кот," + $" возрастом - {age}");
                }
                else
                {
                    if (age < 1) Console.Write("Котёнок женского пола," + $" возрастом - {age}");
                    else if (age < 5) Console.Write("Кошка," + $" возрастом - {age}");
                    else Console.Write("Старая кошка," + $" возрастом - {age}");
                }
                Console.Write($"\tВесом - {weight}");
            }
        }
        class Dog : pet
        {
            public void DogInformation()
            {
                if (gender)
                {
                    if (age < 1) Console.Write("Щенок мужского пола," + $" возрастом - {age}");
                    else if (age < 5) Console.Write("Пёс," + $" возрастом - {age}");
                    else Console.Write("Старый пёс," + $" возрастом - {age}");
                }
                else
                {
                    if (age < 1) Console.Write("Щенок женского пола," + $" возрастом - {age}");
                    else if (age < 5) Console.Write("Собака женского пола," + $" возрастом - {age}");
                    else Console.Write("Старая собака женского пола," + $" возрастом - {age}");
                }
                Console.Write($"\tВесом - {weight}");
            }
        }

        class fish
        {
            protected string mnogoclet = "mnogocletochnoe";
            private string dgabri = "dgabri";
            public void fishInfo()
            {
                Console.WriteLine($"U rib est': {mnogoclet}, {dgabri} ");
            }   
        }
        class animal : fish
        {
            protected string organidihaniya = "legkie";
            private string mnogoobrazievidov = "mnogo vidov";
            public void aniamalInfo()
            {
                Console.WriteLine($"U animals est': {organidihaniya}, {mnogoclet}, {mnogoobrazievidov} ");
            }
        }
        class ape : animal
        {
            protected string RabochiePalchiki = "Bolshie pal'chi rabotaut kak nado ;)";
            private string razum = "Poka ne ispol'zuetsya na polyu razum";
            public void apeInfo()
            {
                Console.WriteLine($"U apes est': {RabochiePalchiki}, {razum}, {organidihaniya}, {mnogoclet} ");
            }
        }
        class human : ape
        {
            protected string spinaPryamaya = "Pryamohoshdenie";
            private string  Soznanie = "Uge rabotaush'ii razum(krome students)";
            public void humanInfo()
            {
                Console.WriteLine($"U humana est': {Soznanie}, {spinaPryamaya}, {RabochiePalchiki}, {mnogoclet}, {organidihaniya} ");
            }
        }
    }
}
