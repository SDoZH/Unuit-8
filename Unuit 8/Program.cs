using System;

namespace Unuit_8
{
    using System;
    using System.IO;
    namespace DriveManager
    {
        class Program
        {
            static void Main(string[] args)
            {
                GetCatalogs(); //   Вызов метода получения директорий
                Console.WriteLine();
                Sum(); //колличество файлов в корне
            }
            static void Sum()
            {
                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(@"/" /* Или С:\\ для Windows */ );
                    if (dirInfo.Exists)
                    {
                        Console.WriteLine("На вашем диске {0} директорий/и", dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            static void GetCatalogs()
            {
                string dirName = @"/"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
                if (Directory.Exists(dirName)) // Проверим, что директория существует
                {
                    Console.WriteLine("Папки:");
                    string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                    foreach (string d in dirs) // Выведем их все
                        Console.WriteLine(d);

                    Console.WriteLine();
                    Console.WriteLine("Файлы:");
                    string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                    foreach (string s in files)   // Выведем их все
                        Console.WriteLine(s);
                }
            }
        }
    }
}