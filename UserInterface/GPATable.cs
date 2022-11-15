using GPA_Calculator__week_one_task_.Calculator;
using GPA_Calculator__week_one_task_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator__week_one_task_.UserInterface
{
    public class GPATable
    {
        public static int tableWidth = 100;
       
        public static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        public static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";
            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }
            Console.WriteLine(row);
        }
        public static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
        public static void MakeDynamicTable(List<CourseInfo> savedCourses)
        {
            Console.Clear();
            Console.WriteLine("DorisDunu University GPA");
            GPATable.PrintLine();
            GPATable.PrintRow("COURSE & CODE", "COURSE-UNIT", "GRADE", "GRADE-UNIT", "REMARK");
            GPATable.PrintLine();
            foreach (var course in savedCourses)
            {
                GPATable.PrintRow(course.CourseName, course.CourseUnit.ToString(), course.CourseGrade.ToString(), course.CourseGradeUnit.ToString(), course.Remark);
            }
            GPATable.PrintLine();
            var GPA = GPACalculator.GPAResult(savedCourses);
            Console.WriteLine($"Your GPA is: {GPA}");
        }
    }
}
