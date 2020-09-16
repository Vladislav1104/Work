using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Circle circle1 = new Circle(0, 0, 5);
                Circle circle2;
                Console.WriteLine("Лаб №1");
                Console.ReadLine();
                Console.WriteLine("\n№ 1 \nДлина окружности = " + circle1.CircleLengtht());
                Console.ReadLine();
                Console.WriteLine("\n№ 2");
                circle1.ChanCenter();
                Console.ReadLine();
                Console.WriteLine("\n№ 3");
                circle2 = new Circle();
                Console.ReadLine();
                Console.WriteLine("\n№ 4");
                Console.WriteLine("\nПервая окружность:");
                circle1.Coord();
                Console.WriteLine("\nВторая окружность:");
                circle2 = new Circle();
                Console.WriteLine($"\nРасстояние между центрами двух окружностей равна {circle1.Distance(circle2)}");
                Console.ReadLine();
                Console.WriteLine("№ 5");
                Console.WriteLine("\nПервая окружность:");
                circle1.Coord();
                Console.WriteLine("\nВторая окружность:");
                circle2 = new Circle();
                Console.WriteLine("\nКоличество точек пересечения окружностей: " + circle1.Touch(circle2));
                Console.ReadLine();
            }
        }

        class Circle
        {
            double x, y, r;

            public Circle(double x, double y, double r)
            {
                this.x = x;
                this.y = y;
                this.r = r;
            }

            public Circle()
            {
                Console.Write("Введите координаты центра окружности \nx=");
                while (!double.TryParse(Console.ReadLine(), out x)) ;
                Console.Write("y=");
                while (!double.TryParse(Console.ReadLine(), out y)) ;
                Console.Write("Введите радиус окружности \nr=");
                while (!double.TryParse(Console.ReadLine(), out r)) ;
                Coord();
            }

            public double CircleLengtht()
            {
                return Math.PI * 2 * r;
            }

            public void ChanCenter()
            {
                Random random = new Random();
                x = random.Next(-99, 100);
                y = random.Next(-99, 100);
                Console.WriteLine($"Центр окружности перемещён в координаты x={x} и y={y}");
            }

            public double Distance(Circle a)
            {
                return Math.Sqrt(Math.Pow(a.x - x, 2) + Math.Pow(a.y - y, 2));
            }

            public string Touch(Circle a)
            {
                if (x == a.x && y == a.y && r == a.r)
                    return "бесконечное, круги совпадают";

                if (Distance(a) <= Math.Abs(r - a.r))
                {
                    if (Distance(a) == Math.Abs(r - a.r))
                        return "1";
                    else if (Distance(a) < Math.Abs(r - a.r))
                        return "0";
                    else
                        return "2";
                }

                else
                {
                    if (Distance(a) == Math.Abs(r + a.r))
                        return "1";
                    else if (Distance(a) > Math.Abs(r + a.r))
                        return "0";
                    else
                        return "2";
                }

            }
            public void Coord()
            {
                Console.WriteLine($"Координаты окружности x={x}, y={y}, r={r}");
            }
        }
    }
}
