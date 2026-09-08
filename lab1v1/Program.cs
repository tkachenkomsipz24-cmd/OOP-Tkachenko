using System;

namespace lab1v1
{
    // Клас за варіантом 1: Book
    public class Book
    {
        // Приватні поля
        private string title;
        private string author;

        // Публічна властивість
        public int Year { get; set; }

        // Конструктор для ініціалізації
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            Year = year;
        }

        // Деструктор
        ~Book()
        {
            Console.WriteLine($"[Деструктор] Об'єкт книги \"{title}\" видалено.");
        }

        // Метод для отримання інформації
        public string GetInfo()
        {
            return $"Книга: \"{title}\" | Автор: {author} | Рік: {Year}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення 3 об'єктів класу Book
            Book book1 = new Book("Кобзар", "Тарас Шевченко", 1840);
            Book book2 = new Book("Тіні забутих предків", "Михайло Коцюбинський", 1911);
            Book book3 = new Book("Місто", "Валеріан Підмогильний", 1928);

            // Виклик методу GetInfo та вивід у консоль
            Console.WriteLine(book1.GetInfo());
            Console.WriteLine(book2.GetInfo());
            Console.WriteLine(book3.GetInfo());
        }
    }
}