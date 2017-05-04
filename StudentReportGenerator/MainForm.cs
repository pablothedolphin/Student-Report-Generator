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
    public enum Grade
    {
        Level4C, Level4B, Level4A, Level5C, Level5B, Level5A, Level6C, Level6B, Level6A, Level7C, Level7B, Level7A, Level8C, Level8B, Level8A, Level9C, Level9B, Level9A
    };

    public partial class MainForm : Form
    {
        string studentName = "Example";
        Grade studentCurrentGrade = Grade.Level4C;
        Grade studentTargetGrade = Grade.Level4C;
        string currentGradeText = "4C";
        string targetGradeText = "4C";

        string capitalHeShe = "He";
        string lowerHeShe = "he";
        string capitalHisHer = "His";
        string lowerHisHer = "his";
        string lowerHimHer = "him";

        string studentEngagement = "disengaged";
        string studentBehaviour1 = "rude and poorly behaved";
        string studenBehaviour2;

        int reportsWritten = 0;

        List<string> students = new List<string>();
        List<string> reports = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            currentGrade.SelectedIndex = 0;
            targetGrade.SelectedIndex = 0;
            engagement.SelectedIndex = 0;
            behaviour1.SelectedIndex = 0;
        }

        private void SetStudentName(object sender, EventArgs e)
        {
            studentName = studentNameField.Text;
            UpdateReport();
        }

        private void SetGenderMale(object sender, EventArgs e)
        {
            capitalHeShe = "He";
            lowerHeShe = "he";
            capitalHisHer = "His";
            lowerHisHer = "his";
            lowerHimHer = "him";

            UpdateReport();
        }

        private void SetGenderFemale(object sender, EventArgs e)
        {
            capitalHeShe = "She";
            lowerHeShe = "she";
            capitalHisHer = "Her";
            lowerHisHer = "her";
            lowerHimHer = "her";

            UpdateReport();
        }

        private void SetCurrentGrade(object sender, EventArgs e)
        {
            currentGradeText = currentGrade.SelectedItem.ToString();

            studentCurrentGrade = Grade.Level4C;

            if (currentGradeText == "4B") studentCurrentGrade += 1;
            else if (currentGradeText == "4A") studentCurrentGrade += 2;
            else if (currentGradeText == "5C") studentCurrentGrade += 3;
            else if (currentGradeText == "5B") studentCurrentGrade += 4;
            else if (currentGradeText == "5A") studentCurrentGrade += 5;
            else if (currentGradeText == "6C") studentCurrentGrade += 6;
            else if (currentGradeText == "6B") studentCurrentGrade += 7;
            else if (currentGradeText == "6A") studentCurrentGrade += 8;
            else if (currentGradeText == "7C") studentCurrentGrade += 9;
            else if (currentGradeText == "7B") studentCurrentGrade += 10;
            else if (currentGradeText == "7A") studentCurrentGrade += 11;
            else if (currentGradeText == "8C") studentCurrentGrade += 12;
            else if (currentGradeText == "8B") studentCurrentGrade += 13;
            else if (currentGradeText == "8A") studentCurrentGrade += 14;
            else if (currentGradeText == "9C") studentCurrentGrade += 15;
            else if (currentGradeText == "9B") studentCurrentGrade += 16;
            else if (currentGradeText == "9A") studentCurrentGrade += 17;

            UpdateReport();
        }

        private void SetTargetGrade(object sender, EventArgs e)
        {
            targetGradeText = targetGrade.SelectedItem.ToString();

            studentTargetGrade = Grade.Level4C;

            if (targetGradeText == "4B") studentTargetGrade += 1;
            else if (targetGradeText == "4A") studentTargetGrade += 2;
            else if (targetGradeText == "5C") studentTargetGrade += 3;
            else if (targetGradeText == "5B") studentTargetGrade += 4;
            else if (targetGradeText == "5A") studentTargetGrade += 5;
            else if (targetGradeText == "6C") studentTargetGrade += 6;
            else if (targetGradeText == "6B") studentTargetGrade += 7;
            else if (targetGradeText == "6A") studentTargetGrade += 8;
            else if (targetGradeText == "7C") studentTargetGrade += 9;
            else if (targetGradeText == "7B") studentTargetGrade += 10;
            else if (targetGradeText == "7A") studentTargetGrade += 11;
            else if (targetGradeText == "8C") studentTargetGrade += 12;
            else if (targetGradeText == "8B") studentTargetGrade += 13;
            else if (targetGradeText == "8A") studentTargetGrade += 14;
            else if (targetGradeText == "9C") studentTargetGrade += 15;
            else if (targetGradeText == "9B") studentTargetGrade += 16;
            else if (targetGradeText == "9A") studentTargetGrade += 17;

            UpdateReport();
        }

        private void SetEngagement(object sender, EventArgs e)
        {
            studentEngagement = engagement.SelectedItem.ToString();

            UpdateReport();
        }

        private void SetBehaviour1(object sender, EventArgs e)
        {
            studentBehaviour1 = behaviour1.SelectedItem.ToString();

            UpdateReport();
        }

        private void UpdateReport()
        {
            currentReport.Text = "" + studentName + " is a " + studentEngagement + " member of " + lowerHisHer + " class. ";

            currentReport.Text += capitalHeShe + " is " + studentBehaviour1 + ", ";

            currentReport.Text += "\n\n" + studentName + " is currently working at a level " + currentGradeText + " which is ";

            if (studentCurrentGrade < studentTargetGrade) currentReport.Text += "bellow ";
            else if (studentCurrentGrade == studentTargetGrade) currentReport.Text += "on ";
            else currentReport.Text += "above ";

            currentReport.Text += lowerHisHer + " target for the year. ";

            if (studentCurrentGrade < studentTargetGrade)
                currentReport.Text += "However, with some extremely hard work " + lowerHeShe + " has the potential to achieve " + lowerHisHer + " target of " + targetGradeText + ". ";

            else if (studentCurrentGrade == studentTargetGrade)
                currentReport.Text += "If " + lowerHeShe + " stays consistent in " + lowerHisHer + " performance, there is no doubt " + lowerHeShe + " can aim higher than a " + targetGradeText + ". ";

            else
                currentReport.Text += "With some more attention to " + lowerHisHer + " classwork, " + lowerHeShe + " can easily begin to accel in Computing. ";

            currentReport.Text += "\n\n";
        }

        private void AddReportToList(object sender, EventArgs e)
        {
            reportsWritten++;
            completedReportsLable.Text = "Completed Reports: " + reportsWritten;

            students.Add(studentName);
            reports.Add(currentReport.Text);
        }

        private void SaveReportsToFile(object sender, EventArgs e)
        {
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            mySaveFileDialog.Filter = "txt files (*.txt)|*.txt";
            mySaveFileDialog.RestoreDirectory = true;

            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream myStream = File.Open(mySaveFileDialog.FileName, FileMode.Create))
                using (StreamWriter myStreamWriter = new StreamWriter(myStream))
                {
                    for (int i = 0; i < reports.Count; i++)
                    {
                        myStreamWriter.WriteLine(students[i] + "'s Report:");
                        myStreamWriter.WriteLine("");

                        string[] reportLine = reports[i].Split('\n');
                        for (int j = 0; j < reportLine.Length; j++)
                        {
                            myStreamWriter.WriteLine(reportLine[j]);
                        }
                    }
                }
            }
        }
    }
}
