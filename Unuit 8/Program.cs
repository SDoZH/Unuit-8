using System;

namespace Unuit_8
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    namespace Serialization
    {

        // Описываем наш класс и помечаем его атрибутом для последующей сериализации   
        [Serializable]
        class Contact
        {
            public string Name { get; set; }
            public long PhoneNumber { get; set; }
            public string Email{get; set;}
            public Contact(string name, long phoneNumber, string email)
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // объект для сериализации
                var person = new Contact("Alex",9253237979, "Soldatov_alex@bk.ru");
                Console.WriteLine("Объект создан");

                BinaryFormatter formatter = new BinaryFormatter();
                // получаем поток, куда будем записывать сериализованный объект
                using (var fs = new FileStream("/Users/Dzh/Desktop/Contact1.bin", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, person);
                    Console.WriteLine("Объект сериализован");
                }
      
            }
        }
    }
}

