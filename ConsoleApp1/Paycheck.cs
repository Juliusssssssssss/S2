using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Paycheck
    {
        #region Fields
        private (DateTime start, DateTime end) interval;
        private double taxPercentage;
        private decimal hoursWorked;
        private decimal hourlyRate;
        #endregion

        #region Constants
        private readonly DateTime minimumIntervalDate = new DateTime(2000, 1, 1); // CTRL + E + V = Copy this Line !shortcuts
        private readonly DateTime maximumIntervalDate = new DateTime(2050, 1, 1);
        #endregion

        #region Constructs
        public Paycheck((DateTime start, DateTime end) interval, double taxPercentage, decimal hoursWorked, decimal hourlyRate)
        {
            Interval = interval;
            TaxPercentage = taxPercentage;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }
        #endregion

        #region Properties
        public (DateTime start, DateTime end) Interval //Mus over "set" (CTRL + .) Then Enter. !shortcut
        {
            get => interval; 
            set
            {
                DateTime start = value.start;
                DateTime end = value.end;
                if(start < minimumIntervalDate)
                {
                    throw new ArgumentOutOfRangeException("Start date is too early");
                }
                else if (end > maximumIntervalDate)
                {
                    throw new ArgumentOutOfRangeException("End date is too late");
                }
                else if (end < start)
                {
                    throw new ArgumentOutOfRangeException("End is earlier than start");
                }

                if (start.AddDays(13) == end.Date) //14 days (Period)
                {
                    if (start.DayOfWeek == DayOfWeek.Monday)
                    {
                        interval = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("14 day Interval does not start on a monday");
                    }
                
                }
                else //Monthly (Period)
                {
                    if (start.Day != 1)
                    {
                        throw new ArgumentOutOfRangeException("First day of provided monthly interval is not day 1 in that month");
                    }
                    else
                    {
                        int daysInMonth = DateTime.DaysInMonth(start.Year, start.Month);
                        if (start.AddDays(daysInMonth) != end.Date)
                        {
                            throw new ArgumentOutOfRangeException("No, notgood");
                        }
                        else
                        {
                            interval = value;
                        }
                    }
                }

            }
        }
        public double TaxPercentage
        {
            get => taxPercentage; set
            {
                taxPercentage = value;
            }
        }
        public decimal HoursWorked
        {
            get => hoursWorked; set
            {
                hoursWorked = value;
            }
        }
        public decimal HourlyRate
        {
            get => hourlyRate; set
            {
                hourlyRate = value;
            }
        }
        #endregion

        #region Methods
        public decimal GetGrossSalary()
        {
            return default;
        }
        public decimal GetNetSalary()
        {
            return default;
        }
        public decimal GetTaxSalary()
        {
            return default;
        }
        #endregion
    }
}