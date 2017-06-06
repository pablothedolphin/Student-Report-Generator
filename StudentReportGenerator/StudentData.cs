using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportGenerator
{ 
    public enum Grade
    {
        Level4C, Level4B, Level4A, Level5C, Level5B, Level5A, Level6C, Level6B, Level6A, Level7C, Level7B, Level7A, Level8C, Level8B, Level8A, Level9C, Level9B, Level9A
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
    }
}
