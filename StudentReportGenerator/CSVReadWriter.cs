using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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

        public void SaveReportsToTextFile(List<string> _studentReports)
        {
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            mySaveFileDialog.Filter = "txt files (*.txt)|*.txt";
            mySaveFileDialog.RestoreDirectory = true;

            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream myStream = File.Open(mySaveFileDialog.FileName, FileMode.Create))
                using (StreamWriter myStreamWriter = new StreamWriter(myStream))
                {
                    for (int i = 0; i < _studentReports.Count; i++)
                    {
                        myStreamWriter.WriteLine(_studentReports[i] + "'s Report:");
                        myStreamWriter.WriteLine("");

                        string[] reportLine = _studentReports[i].Split('\n');
                        for (int j = 0; j < reportLine.Length; j++)
                        {
                            myStreamWriter.WriteLine(reportLine[j]);
                        }
                    }
                }
            }
        }

        public void SaveReportsToCSV(List<StudentData> _studentDataList)
        {
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            mySaveFileDialog.Filter = "CSV|*.csv";
            mySaveFileDialog.DefaultExt = ".csv";
            mySaveFileDialog.RestoreDirectory = true;

            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
               List<string> studentDataStrings = ConvertStudentDataToStrings(_studentDataList);

                using (Stream myStream = File.Open(mySaveFileDialog.FileName, FileMode.Create))
                using (StreamWriter myStreamWriter = new StreamWriter(myStream))
                {
                    string headingsString = "Student Name, Current Grade, Target Grade, Year Group, Report";
                    myStreamWriter.WriteLine(headingsString);

                    for(int i = 0; i < studentDataStrings.Count; i++)
                    {
                        myStreamWriter.WriteLine(studentDataStrings[i]);
                    }
                }

            }
        }

        public List<string> ConvertStudentDataToStrings(List<StudentData> _studentDataObjs)
        {
            List<string> studentDataStrings = new List<string>();

            string studentRecordStr = "";

            foreach (StudentData studentObj in _studentDataObjs)
            {
                studentRecordStr = studentObj.StudentName + "," + studentObj.CurrentGrade.ToString() + "," + studentObj.TargetGrade.ToString() + "," + studentObj.YearGroup.ToString()
                 + "," + Escape(studentObj.Report);

                studentDataStrings.Add(studentRecordStr);
            }


            return studentDataStrings;
        }

        public String Escape(String s)
        {
            if (s != null)
            {
                StringBuilder sb = new StringBuilder();
                bool needQuotes = false;
                foreach (char c in s.ToArray())
                {
                    switch (c)
                    {
                        case '"': sb.Append("\\\""); needQuotes = true; break;
                        case ' ': sb.Append(" "); needQuotes = true; break;
                        case ',': sb.Append(","); needQuotes = true; break;
                        case '\t': sb.Append("\\t"); needQuotes = true; break;
                        case '\n': break;
                        default: sb.Append(c); break;
                    }
                }
                if (needQuotes)
                    return "\"" + sb.ToString() + "\"";
                else
                    return sb.ToString();
            }

            return "";
        }
    }
}
