using GPA_Calculator__week_one_task_.Data;
using Pango;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator__week_one_task_.Calculator
{
    public class GPACalculator
    {
        public static CourseInfo GradeGenerator(CourseInfo course)
        {
            if (course.CourseScore >= 70 && course.CourseScore <= 100)
            {
                course.CourseGrade = "A";
                course.CourseGradeUnit = 5;
                course.Remark = "excellent";

            }

            else if (course.CourseScore >= 60 && course.CourseScore <= 69)
            {
                course.CourseGrade = "B";
                course.CourseGradeUnit = 4;
                course.Remark = "Very Good";
            }

            else if (course.CourseScore >= 50 && course.CourseScore <= 59)
            {
                course.CourseGrade = "C";
                course.CourseGradeUnit = 3;
                course.Remark = "Good";
            }

            else if (course.CourseScore >= 45 && course.CourseScore <= 49)
            {
                course.CourseGrade = "D";
                course.CourseGradeUnit = 2;
                course.Remark = "Fair";
            }

            else if (course.CourseScore >= 40 && course.CourseScore <= 44)
            {
                course.CourseGrade = "E";
                course.CourseGradeUnit = 1;
                course.Remark = "Pass";
            }

            else if (course.CourseScore >= 0 && course.CourseScore <= 39)
            {
                course.CourseGrade = "F";
                course.CourseGradeUnit = 0;
                course.Remark = "Fail";
            }

            return course;
        }

        public static double GPAResult(List<CourseInfo> courses)
        {
            double TotalWeightPoint = 0;
            double TotalCourseUnit = 0;
            double WeightUnit = 0;

            foreach(CourseInfo course in courses)
            {
                WeightUnit = course.CourseUnit * course.CourseGradeUnit;
                TotalWeightPoint += WeightUnit;

                TotalCourseUnit += course.CourseUnit;

            }

            double GPA = TotalWeightPoint / TotalCourseUnit;
            double result = Math.Round(GPA, 2, MidpointRounding.AwayFromZero);
            return result;

        }

    }
}



