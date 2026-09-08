using System;

namespace lab1v5
{
    // Клас за варіантом 5: City
    public class City
    {
        // Приватні поля
        private string name;
        private string country;

        // Публічна властивість
        public int Population { get; set; }

        // Конструктор для ініціалізації
        public City(string name, string country, int population)
        {
            this.name = name;
            this.country = country;
            Population = population;
        }

        // Деструктор
        ~City()
        {
            Console.WriteLine($"[Деструктор] Об'єкт міста \"{name}\" видалено.");
        }

        // Метод для отримання інформації
        public string GetInfo()
        {
            return $"Місто: {name} | Країна: {country} | Населення: {Population} осіб";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення 3 об'єктів класу City
            City city1 = new City("Київ", "Україна", 2950000);
            City city2 = new City("Токіо", "Японія", 13960000);
            City city3 = new City("Париж", "Франція", 2161000);

            // Виклик методу GetInfo та вивід у консоль
            Console.WriteLine(city1.GetInfo());
            Console.WriteLine(city2.GetInfo());
            Console.WriteLine(city3.GetInfo());
        }
    }
}