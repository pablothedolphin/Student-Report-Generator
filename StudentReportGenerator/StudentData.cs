using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportGenerator
{
    public enum Grade
    {
        Level4C, Level4B, Level4A, Level5C, Level5B, Level5A, Level6C, Level6B, Level6A, Level7C, Level7B, Level7A, Level8C, Level8B, Level8A, Level9C, Level9B, Level9A, DEFAULT
    };

    class StudentData
    {
        private string studentName;
        private Grade currentGrade;
        private Grade targetGrade;
        private string yearGroup;

        public StudentData(string _name, Grade _current, Grade _target, string _year)
        {
            studentName = _name;
            currentGrade = _current;
            targetGrade = _target;
            yearGroup = _year;
        }

        public StudentData()
        {

        }

        public static StudentData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            StudentData data = new StudentData();
            data.studentName = values[0];
            data.currentGrade = data.SetGrade(values[1]);
            data.targetGrade = data.SetGrade(values[2]);
            data.yearGroup = values[3];

            return data;
        }

        public Grade SetGrade(string _gradeString)
        {
            switch (_gradeString)
            {
                case "4C":
                    return Grade.Level4C;
                case "4B":
                    return Grade.Level4B;
                case "4A":
                    return Grade.Level4A;
                case "5C":
                    return Grade.Level5C;
                case "5B":
                    return Grade.Level5B;
                case "5A":
                    return Grade.Level5A;
                case "6C":
                    return Grade.Level6C;
                case "6B":
                    return Grade.Level6B;
                case "6A":
                    return Grade.Level6A;
                case "7C":
                    return Grade.Level7C;
                case "7B":
                    return Grade.Level7B;
                case "7A":
                    return Grade.Level7A;
                case "8C":
                    return Grade.Level8C;
                case "8B":
                    return Grade.Level8B;
                case "8A":
                    return Grade.Level8A;
                case "9C":
                    return Grade.Level9A;
                case "9B":
                    return Grade.Level9B;
                case "9A":
                    return Grade.Level9A;
            }

            return Grade.DEFAULT;
        }
    }
}
