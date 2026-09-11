using System;

namespace lab1v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book book1 = new Book("Кобзар", "Тарас Шевченко", 1840);
            Book book2 = new Book("Тіні забутих предків", "Михайло Коцюбинський", 1911);
            Book book3 = new Book("Місто", "Валеріян Підмогильний", 1928);

            Console.WriteLine(book1.GetInfo());
            Console.WriteLine(book2.GetInfo());
            Console.WriteLine(book3.GetInfo());

            Console.WriteLine("\n--- Перевірка властивості Year ---");
            book1.Year = 2024;
            Console.WriteLine($"Оновлено: {book1.GetInfo()}");
        }
    }
}