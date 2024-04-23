using System;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Въведете първото цяло число:");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Въведете второто цяло число:");
                int number2 = int.Parse(Console.ReadLine());

                int result = number1 / number2;
                Console.WriteLine($"Резултатът от делението е: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Въведете цяло число.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делението на нула не е възможно");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }

        }
    }
}