using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Subject
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Input");
                }
                else
                {
                    name = value;
                }
            }
        }
        private string teacher;
        public string Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Input");
                }
                else
                {
                    teacher = value;
                }
            }
        }
        private DateTime examtime;
        public DateTime ExamTime
        {
            get
            {
                return examtime;
            }
            set 
            {
                DateTime minimum = new DateTime(1900, 1, 1);
                if (value < minimum)
                {
                    throw new ArgumentException("Invalid Input");
                }
           }
        }
        public DateTime SDate { get; set; }
        private string point;
        public string Point
        {
            get
            {
                return point;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Input");
                }
                else
                {
                    point = value;
                }
            }
        }
        private string code;
        public string Code {
            get {
                return code;
                }
                set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Input");
                }
            }
           }
        public DateTime EDate { get; set; }
    }
}
