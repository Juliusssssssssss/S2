using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    class Person
    {
        public string GetInitials()
        {
            string initials = "";
            initials += FirstName[0]; initials += FirstName[1];
            initials += LastName[0]; initials += LastName[1]; 
            return initials;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public int GetAgeToday()
        {
            int year = DateTime.Now.Year;
            int age = BirthDate.Year;
            return year - age; 
        }
        public bool IsOlderThan(int age)
        {
            if (age > BirthDate.Year)
            {
                return true;
            }
            else
                return false;
        }
    }
}
