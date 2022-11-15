using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VisioForge.Libs.MediaFoundation.dxvahd;

namespace GPA_Calculator__week_one_task_.UserInterface
{
    public static class Validator
    {
        public static bool EmptyValidation(string input)
        {
            if (input == null) 
            { return false; }

            bool v = int.TryParse(input, out int value);
            return v;
        }

        public static bool CourseMatch(string input)
        {
            if (!Regex.Match(input, @"^\b{0,3}\d{0,3}$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool CourseUnit(string input)
        {
            var result = Convert.ToInt32(input);

            if (result >= 0 && result <= 5)
            {
                return true;
            }
            return false;
        }

        public static bool CourseScore(string input)
        {
            var value = Convert.ToInt32(input);

            if (value >= 0 && value <= 100)
            {
                return true;
            }
            return false;

        }
    }
}

