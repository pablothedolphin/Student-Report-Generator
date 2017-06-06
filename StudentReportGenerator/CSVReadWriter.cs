using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace StudentReportGenerator
{
    class CSVReadWriter
    {

        public List<StudentData> GetStudentDataFromCSV(string _csvName)
        {
            //ignores first line of headers in file and converts other rows into student data objs
            List<StudentData> data = File.ReadAllLines(_csvName)
                                         .Skip(1)
                                         .Select(d => StudentData.FromCsv(d))
                                         .ToList();
            return data;
        }
    }
}
