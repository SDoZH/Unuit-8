using System;

namespace Unuit_8
{
    using System;
    using System.IO;
    class Task
    { 
        class Program
        {
            public static void Main()
            {
                WriteValues();
                ReadValues();
            }

            static void WriteValues()
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open("/Users/Dzh/Desktop/BinaryFile.bin", FileMode.Open)))
                    writer.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
            }

            static void ReadValues()
            {
                string StringValue;

                if (File.Exists("/Users/Dzh/Desktop/BinaryFile.bin"))
                {
                    using (BinaryReader reader = new BinaryReader(File.Open("/Users/Dzh/Desktop/BinaryFile.bin", FileMode.Open)))
                    {
                        StringValue = reader.ReadString();
                    }

                    Console.WriteLine(StringValue);
                }
            }
        }
    }
}

