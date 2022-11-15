using GPA_Calculator__week_one_task_.Calculator;
using GPA_Calculator__week_one_task_.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator__week_one_task_.UserInterface
{
    public class AppDisplay
    {
            private string userName = string.Empty;
            private string courseName = string.Empty;
            public string control = string.Empty;
            public string Username { get; set; }
            private readonly string controlMessage = "To add a course type \"YES\"";
        public void InterfaceChecker()
        {
            //sets console Title
            Console.Title = "My GPA CALCULATOR";
            //sets the foreground color to White
            Console.ForegroundColor = ConsoleColor.White;

            //sets the welcome message
            Console.WriteLine("\n\n------------------- My GPA CALCULATOR --------------------");
            Console.WriteLine("it,s a pleasure to have you here...     ");

 
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome to CGPA calculator");
            Console.WriteLine("pls insert your Name");
            Username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(controlMessage);
            control = Console.ReadLine();
            var SavedCourses = new List<CourseInfo>();
            if (control == "yes" || control == "YES")
            {
                string command;
                do
                {
                    CourseInfo NewCourse = new CourseInfo();
                    var courseScore = "";
                    var courseUnit = "";
                    while (true)
                    {
                        Console.WriteLine($"Hello {Username}, Please enter your Course Name & Code e.g \"MTS101\"");
                        courseName = Console.ReadLine();
                        var validData = Validator.CourseMatch(courseName);
                        if (validData == true)
                        {
                            NewCourse.CourseName = courseName.ToUpper().Trim();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please input a valid course name e.g \"MTS101\"");
                            continue;
                        }
                        break;
                    }
                     
                    while (true)
                    {
                        Console.WriteLine($"Hello {Username}, Please enter your Course Unit");
                        courseUnit = Console.ReadLine();
                        if (Validator.CourseUnit(courseUnit) == true)
                        {
                            NewCourse.CourseUnit = Convert.ToInt32(courseUnit);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please input a valid coures unit ranging from 1-5");
                            continue;
                        }
                        break;
                    }

                    while (true)
                    {
                        Console.WriteLine($"Hello {Username}, Please enter your Course Score");
                        courseScore = Console.ReadLine();
                        if (Validator.CourseScore(courseScore)== true)
                        {
                            NewCourse.CourseScore = Convert.ToInt32(courseScore);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please input a valid score ranging from 0-100");
                            continue;
                        }
                        break;
                    }

                    var ModifiedCourse = GPACalculator.GradeGenerator(NewCourse);
                    SavedCourses.Add(ModifiedCourse);
                    Console.WriteLine("Do you want to add to the table? please input yes or no to stop");
                    command = Console.ReadLine().ToLower().Trim();
                    if (command == "no") break;
                } while (command == "yes");
                GPATable.MakeDynamicTable(SavedCourses);
                Console.WriteLine("continue making progress");
            }

        }
    }
}
