using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CourseWeek2Lesson7
{
    public enum Grade
    {
        Niedostateczna,
        Dopuszczająca,
        Dostateczna,
        Dobra,
        [Description("Bardzo Dobra")]
        BardzoDobra,
        Celująca
    }
}
