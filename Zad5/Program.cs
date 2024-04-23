using System;

namespace Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Time time = new Time();

                Console.WriteLine("Въведи часове:");
                int hour = int.Parse(Console.ReadLine());

                Console.WriteLine("Въведи минути:");
                int minute = int.Parse(Console.ReadLine());

                Console.WriteLine("Въведи секунди:");
                int second = int.Parse(Console.ReadLine());

                time.SetTime(hour, minute, second);
                time.ShowTime();
            }
            catch (FormatException)
            {
                Console.WriteLine("Невалидни данни.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Край на програмата");
            }

        }
    }


    class Time
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour
        {
            get { return hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException("Часовете трябва да са между 0 и 23ч.");
                }
                hour = value;
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException("Минутите трябва да са между 0 и 59.");
                }
                minute = value;
            }
        }

        public int Second
        {
            get { return second; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException("Секундите трябва да са между 0 и 59.");
                }
                second = value;
            }
        }

        public void SetTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public void ShowTime()
        {
            Console.WriteLine($"Време: {Hour:D2}:{Minute:D2}:{Second:D2}");
        }
    }

}