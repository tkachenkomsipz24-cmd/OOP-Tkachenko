using System;

namespace lab1v1
{
    public class Book
    {
        private string title;
        private string author;
        private int year;

        public int Year
        {
            get => year;
            set
            {
                if (value > 0 && value <= DateTime.Now.Year)
                    year = value;
                else
                    Console.WriteLine($"[Увага] Некоректний рік: {value}");
            }
        }

        public string Title => title;
        public string Author => author;

        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            Year = year;
        }

        ~Book()
        {
            Console.WriteLine($"[Деструктор] Книгу \"{title}\" видалено.");
        }

        public string GetInfo()
        {
            return $"Книга: \"{title}\" | Автор: {author} | Рік видання: {year}";
        }
    }
}