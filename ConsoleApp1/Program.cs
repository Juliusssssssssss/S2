using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            (DateTime start, DateTime end) Interval = new(new(2022, 4, 1), new(2022, 4, 1));                     //Console.WriteLine("CTRL + E + D = Opsætning af {}'s !shortcuts");
            double TaxPercentage = 0.37;
            decimal WorkedHours = 160.33m;
            decimal HourlyRate = 140m;

            Paycheck p = new(interval: Interval, taxPercentage: TaxPercentage, hoursWorked: WorkedHours, hourlyRate: HourlyRate);
        }
    }
}