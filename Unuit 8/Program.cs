﻿using System;

namespace Unuit_8
{
    using System;
    using System.IO;
    class FileWriter
    {
        public static void Main()
        {
            string filePath = @"\Users\Dzh\source\repos\Unuit 8\Unuit 8\Program.cs"; // Укажем путь
            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);
            }
        }
    }
}