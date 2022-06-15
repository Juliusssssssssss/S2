using System;

namespace Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new();
            p.FirstName = "Karl";
            p.LastName = "Hansen";
            p.BirthDate = new DateTime(1864, 01, 01);

            Person p1 = new();
            p1.FirstName = "Mette";
            p1.LastName = "Frederiksen";
            p1.BirthDate = new DateTime(1865, 01, 01);

            string output = p1.GetFullName();
            Console.WriteLine(output);

            string Initials = p1.GetInitials();
            Console.WriteLine(Initials.ToUpper());

            int age = p1.GetAgeToday();
            Console.WriteLine(age);

            bool old = p1.IsOlderThan(25);
            Console.WriteLine(old);
            if (true)
            {
                Console.WriteLine("You're older than the parameter!");
            }
            else
            {
                Console.WriteLine("You're Younger than the parameter!");
            }
        }
    }
}
