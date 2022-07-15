using System;

namespace Unuit_8
{
    using System;
    using System.IO;
    class Task
    {
        public static void Main()
        {
            var fileInfo = new FileInfo("/Users/Dzh/source/repos/Unuit 8/Unuit 8/Program.cs"); // Укажем путь

            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"Время запуска: {DateTime.Now}");
            }
                // Откроем файл и прочитаем его содержимое
                using (StreamReader sr = fileInfo.OpenText())
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                        Console.WriteLine(str);
                }
            }
        }
    }

