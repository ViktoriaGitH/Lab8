using System;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Въведете число:");
                double number = double.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Invalid number");
                    return;
                }

                double result = Math.Sqrt(number);
                Console.WriteLine($"Корен квадратен от {number} е: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Въведете валидно число.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("End of program");
            }

        }
    }
}