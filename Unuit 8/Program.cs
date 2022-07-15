using System;

namespace Unuit_8
{
    using System;
    using System.IO;
    class Task
    {
        public static void Main()
        {
            var fileInfo = new FileInfo("/Users/Dzh/Desktop/BinaryFile.bin"); // Укажем путь

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

