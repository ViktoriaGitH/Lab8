using System;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Въведете номера на месеца:");
                int monthNumber = int.Parse(Console.ReadLine());

                string monthName = GetMonthName(monthNumber);
                Console.WriteLine($"Месецът с номер {monthNumber} е: {monthName}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Въведете валиден номер на месец.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Невалиден номер на месец.");
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


        static string GetMonthName(int monthNumber)
        {
            string[] months = { "Януари", "Февруари", "Март", "Април", "Май", "Юни", "Юли", "Август", "Септември", "Октомври", "Ноември", "Декември" };

            if (monthNumber < 1 || monthNumber > 12)
            {
                throw new IndexOutOfRangeException();
            }

            return months[monthNumber - 1];
        }
    }
}

