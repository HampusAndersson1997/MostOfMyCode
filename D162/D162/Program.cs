namespace D162
{
    using System;

    public class Clock
    {
        private int hours;
        private int minutes;

        public Clock(int hours, int minutes = 0)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public void Print()
        {
            Console.WriteLine($"Clock: hours = {hours}, minutes = {minutes}");
        }

        public void AddHours(int hours)
        {
            this.hours += hours;
        }

        public void AddMinutes(int minutes)
        {
            this.hours += minutes / 60;
            this.minutes = (this.minutes + minutes) % 60;
        }

        public void AddClock(int hours, int minutes)
        {
            AddHours(hours);
            AddMinutes(minutes);
        }
    }

    public class SmartClock
    {
        private int seconds;

        public SmartClock(int hours, int minutes = 0)
        {
            this.seconds = hours * 3600 + minutes * 60;
        }

        public void Print()
        {
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            Console.WriteLine($"SmartClock: hours = {hours}, minutes = {minutes}");
        }

        public void AddHours(int hours)
        {
            this.seconds += hours * 3600;
        }

        public void AddMinutes(int minutes)
        {
            this.seconds += minutes * 60;
        }

        public void AddClock(int hours, int minutes)
        {
            AddHours(hours);
            AddMinutes(minutes);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock(12);
            c.Print();
            c.AddHours(1);
            c.Print();
            c.AddMinutes(90);
            c.Print();
            c.AddClock(1, 30);
            c.Print();

            SmartClock sc = new SmartClock(12);
            sc.Print();
            sc.AddHours(1);
            sc.Print();
            sc.AddMinutes(90);
            sc.Print();
            sc.AddClock(1, 30);
            sc.Print();
        }
    }
}