using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWeek2Lesson7
{
    public struct Day
    {
        public Day(int number, DayOfWeek name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; set; }
        public DayOfWeek Name { get; set; }
    }

}
