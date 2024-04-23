using System;

namespace Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Въведете броя на градовете:");
                int n = int.Parse(Console.ReadLine());

                string[] cities = new string[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Въведете град №{i + 1}:");
                    cities[i] = Console.ReadLine();
                }

                Console.WriteLine("Градове в прав ред:");
                PrintCities(cities);

                Console.WriteLine("Градове в обратен ред:");
                PrintCitiesReversed(cities);

                Console.WriteLine("Въведете име на град за търсене:");
                string searchCity = Console.ReadLine();
                SearchCity(cities, searchCity);
            }
            catch (FormatException)
            {
                Console.WriteLine("Грешка: Въведете валидно число.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Грешка: Невалиден индекс.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Край на програмата");
            }
        }





        static void PrintCities(string[] cities)
        {
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }

        static void PrintCitiesReversed(string[] cities)
        {
            for (int i = cities.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(cities[i]);
            }
        }

        static void SearchCity(string[] cities, string searchCity)
        {
            bool found = false;
            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i] == searchCity)
                {
                    Console.WriteLine($"Градът {searchCity} е намерен на позиция {i + 1}.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Градът {searchCity} не е намерен.");
            }
        }
    }
}


