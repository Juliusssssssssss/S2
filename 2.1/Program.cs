using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject p = new();
            p.Name = "Oldgræsk Filosof Historie";
            p.Code = "CJG-678";
            p.Teacher = "David Krappenschitz";
            p.Point = "200";
            p.SDate = new DateTime(2021, 05, 12);
            p.EDate = new DateTime(2022, 05, 12);
            p.ExamTime = new DateTime(2022);
        }
    }
}
