using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _61
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;

            do
            {
                Console.Write("Введите строку: ");
                s = Convert.ToString(Console.ReadLine());

            } while (string.IsNullOrWhiteSpace(s) == true);
            Console.WriteLine();

            try
            {

                FileStream binFile = new FileStream("bin.dat", FileMode.Create);
                StreamWriter binFileWriter = new StreamWriter(binFile);

                for (int i = 0; i < s.Length; i++)
                {
                    if (!(char.IsDigit(s[i])))
                    {
                        binFileWriter.Write(s[i]);
                    }
                }

                binFileWriter.Close();
                binFile.Close();
                Console.Write("Вывод: ");
                binFile = new FileStream("bin.dat", FileMode.Open);
                StreamReader binFileReader = new StreamReader(binFile);

                for (var i = 0; i < binFile.Length; i++)
                {
                    Console.Write(binFileReader.ReadLine());
                }


                binFileReader.Close();
                binFile.Close();
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }
            Console.ReadLine();
        }
    }
}
