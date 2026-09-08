using System;

namespace lab1v5
{
    
    public class City
    {
       
        private string name;
        private string country;

        
        public int Population { get; set; }

       
        public City(string name, string country, int population)
        {
            this.name = name;
            this.country = country;
            Population = population;
        }

       
        ~City()
        {
            Console.WriteLine($"[Деструктор] Об'єкт міста \"{name}\" видалено.");
        }

        
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

           
            Console.WriteLine(city1.GetInfo());
            Console.WriteLine(city2.GetInfo());
            Console.WriteLine(city3.GetInfo());
        }
    }
}