using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _622
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string mainPath = "C/temp/";
                string k1Path = "C/temp/K1/";
                string k2Path = "C/temp/K2/";

                if (!Directory.Exists(mainPath))
                {
                    Directory.CreateDirectory(mainPath);
                }

                Directory.CreateDirectory(k1Path);
                Directory.CreateDirectory(k2Path);


                using (StreamWriter writer = new StreamWriter(k1Path + "t1.txt"))
                {
                    writer.WriteLine("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");

                }
                using (StreamWriter writer = new StreamWriter(k1Path + "t2.txt"))
                {
                    writer.WriteLine("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                }
                using (StreamWriter writer = new StreamWriter(k2Path + "t3.txt"))
                {
                    StreamReader readerOne = new StreamReader(k1Path + "t1.txt");
                    writer.Write(readerOne.ReadToEnd());
                    readerOne.Close();
                    StreamReader readerTwo = new StreamReader(k1Path + "t2.txt");
                    writer.WriteLine(readerTwo.ReadToEnd());
                    readerTwo.Close();
                }

                DirectoryInfo infoK1 = new DirectoryInfo(k1Path);
                DirectoryInfo infoK2 = new DirectoryInfo(k2Path);

                foreach (FileInfo info in infoK1.GetFiles())
                {
                    Console.WriteLine($"{info.Directory}\t\t{info.Name}\t\t{info.CreationTime}\t\t\t{info.LastWriteTime}\t\t\t\t{info.Length} Байт");
                    
                }
                foreach (FileInfo info in infoK2.GetFiles())
                {
                    Console.WriteLine($"{info.Directory}\t\t{info.Name}\t\t{info.CreationTime}\t\t\t{info.LastWriteTime}\t\t\t\t{info.Length} Байт");
                }


                if (Directory.Exists(k2Path))
                {
                    if (!Directory.Exists(k1Path + "t2.txt") && !Directory.Exists(k2Path + "t2.txt"))
                    {
                        File.Move(k1Path + "t2.txt", k2Path + "t2.txt");
                    }
                    else
                    {
                        File.Delete(k1Path + "t2.txt");

                    }
                    if (!Directory.Exists(k1Path + "Ct1.txt"))
                    {
                        File.Copy(k1Path + "t1.txt", k2Path + "t1.txt", overwrite: true);
                    }

                    if (!Directory.Exists("C/temp/ALL"))
                        Directory.Move(k2Path, "C/temp/ALL");
                    else
                    {
                        Directory.Delete(k2Path, recursive: true);
                    }

                    Directory.Delete(k1Path, recursive: true);
                    Console.WriteLine();
                    DirectoryInfo infoK3 = new DirectoryInfo("C/temp/ALL");

                    foreach (FileInfo info in infoK3.GetFiles())
                    {
                        Console.WriteLine($"{info.Directory}\t{info.Name}\t\t{info.CreationTime}\t\t\t{info.LastWriteTime}\t\t\t\t{info.Length} Байт");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }

            Console.ReadLine();

            try
            {

                DirectoryInfo info = new DirectoryInfo("Petrov/");
                DirectoryInfo imageFolder = new DirectoryInfo("Petrov/Images/");
                DirectoryInfo textFolder = new DirectoryInfo("Petrov/Word file/");

                Dictionary<string, double> dict = new Dictionary<string, double>();
                
                if (!info.Exists){
                    info.Create();
                }
                if (!imageFolder.Exists){
                    imageFolder.Create();
                }
                if (!textFolder.Exists){
                    textFolder.Create();
                }

                foreach (var fi in info.EnumerateFiles()){
                    if (textFolder.Exists){
                        if (GetFilesWithNeedName(fi.Name)){
                            dict.Add(fi.Name, fi.Length);
                            File.Move("Petrov/" + fi.Name, textFolder + fi.Name);
                        }
                    }
                    if (imageFolder.Exists){
                        if (GetImagesFiles(fi.Name)){
                            dict.Add(fi.Name, fi.Length);
                            File.Copy("Petrov/" + fi.Name, imageFolder + fi.Name, overwrite:true);
                            
                        }
                    }
                }
                String s = String.Format("{0, 15} {1, 31}\n", "Имя файла", "Размер");
                Console.WriteLine(s);
                
                foreach (var pair in dict.OrderByDescending(pair => pair.Value)){
                    Console.WriteLine(string.Format("{0, 15} {1, 28} Кб\n", pair.Key, pair.Value));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }
            Console.ReadLine();
        }
                static bool GetFilesWithNeedName(string name)
                {
                   bool flag = false;
                   string ext = name.Substring(name.LastIndexOf(".")).ToLower();
                   name = name.Substring(0, name.LastIndexOf(".")).ToLower();

                if ((name.Length == 1) && ext == ".txt")
                {
                   for (int i = 0; i < name.Length; i++)
                   {
                     if (name[i] > 'a' && name[i] < 'z')
                     flag = true;
                   }
                }
                return flag;
                }
                static bool GetImagesFiles(string name)
                {
                
                  bool flag = false;
                  string[] exts = { ".jpg", ".jpeg", ".tif", ".tiff", ".bmp", ".png", ".gif", ".dib" };
                  string ext = name.Substring(name.LastIndexOf(".")).ToLower();

                  foreach (string ex in exts)
                  {
                  if (ex == ext)
                  {
                    flag = true;
                  }
                  }
                  return flag;

                }
        }
}
