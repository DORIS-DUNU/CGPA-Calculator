using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator__week_one_task_.Data
{

    //assigning course Properties
    public class CourseInfo
    {
        public CourseInfo()
        {
        }

        //declaring a Constructor

        public CourseInfo(string CourseName, int CourseUnit,  string CourseGrade, int CourseGradeUnit , 
            int CourseWeightPoint, double CourseScore,string Remark )
        {
            this.CourseName = CourseName;
            this.CourseUnit = CourseUnit;
            this.CourseGrade = CourseGrade;
            this.CourseWeightPoint = CourseWeightPoint;
            this.CourseScore = CourseScore;
            this.Remark = Remark;

        }

        public string CourseName { get; set; }
        public int CourseUnit { get; set; }
        public string CourseGrade { get; set; }
        public int CourseGradeUnit { get; set; }
        public int CourseWeightPoint { get; set; }
        public double CourseScore { get; set; }
        public string Remark { get; set; }
    }
}
