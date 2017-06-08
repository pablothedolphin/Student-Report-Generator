namespace StudentReportGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label studentNameLabel;
            System.Windows.Forms.Label currentGradeLabel;
            System.Windows.Forms.Button addReport;
            System.Windows.Forms.Label engagementLabel;
            System.Windows.Forms.Label behaviour1Label;
            System.Windows.Forms.Button saveButton;
            System.Windows.Forms.Label behaviourLabel2;
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.studentNameField = new System.Windows.Forms.TextBox();
            this.reportPreviewLabel = new System.Windows.Forms.Label();
            this.currentGradeDropDown = new System.Windows.Forms.ComboBox();
            this.targetGradeDropDown = new System.Windows.Forms.ComboBox();
            this.targetGradeLabel = new System.Windows.Forms.Label();
            this.currentReport = new System.Windows.Forms.RichTextBox();
            this.engagement = new System.Windows.Forms.ComboBox();
            this.behaviour1 = new System.Windows.Forms.ComboBox();
            this.completedReportsLable = new System.Windows.Forms.Label();
            this.behaviour2 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.recordNumLbl = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            studentNameLabel = new System.Windows.Forms.Label();
            currentGradeLabel = new System.Windows.Forms.Label();
            addReport = new System.Windows.Forms.Button();
            engagementLabel = new System.Windows.Forms.Label();
            behaviour1Label = new System.Windows.Forms.Label();
            saveButton = new System.Windows.Forms.Button();
            behaviourLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            genderLabel.Location = new System.Drawing.Point(212, 63);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(48, 13);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender: ";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentNameLabel.Location = new System.Drawing.Point(38, 63);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(41, 13);
            studentNameLabel.TabIndex = 4;
            studentNameLabel.Text = "Name: ";
            // 
            // currentGradeLabel
            // 
            currentGradeLabel.AutoSize = true;
            currentGradeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            currentGradeLabel.Location = new System.Drawing.Point(399, 63);
            currentGradeLabel.Name = "currentGradeLabel";
            currentGradeLabel.Size = new System.Drawing.Size(79, 13);
            currentGradeLabel.TabIndex = 8;
            currentGradeLabel.Text = "Current Grade: ";
            // 
            // addReport
            // 
            addReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addReport.Location = new System.Drawing.Point(374, 184);
            addReport.Name = "addReport";
            addReport.Size = new System.Drawing.Size(104, 23);
            addReport.TabIndex = 10;
            addReport.Text = "Add Report";
            addReport.UseVisualStyleBackColor = true;
            addReport.Click += new System.EventHandler(this.AddReportToList);
            // 
            // engagementLabel
            // 
            engagementLabel.AutoSize = true;
            engagementLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            engagementLabel.Location = new System.Drawing.Point(38, 104);
            engagementLabel.Name = "engagementLabel";
            engagementLabel.Size = new System.Drawing.Size(73, 13);
            engagementLabel.TabIndex = 13;
            engagementLabel.Text = "Engagement: ";
            // 
            // behaviour1Label
            // 
            behaviour1Label.AutoSize = true;
            behaviour1Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            behaviour1Label.Location = new System.Drawing.Point(230, 104);
            behaviour1Label.Name = "behaviour1Label";
            behaviour1Label.Size = new System.Drawing.Size(70, 13);
            behaviour1Label.TabIndex = 14;
            behaviour1Label.Text = "Behaviour 1: ";
            // 
            // saveButton
            // 
            saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            saveButton.Location = new System.Drawing.Point(637, 437);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(75, 23);
            saveButton.TabIndex = 103;
            saveButton.Text = "Save As";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += new System.EventHandler(this.SaveReportsToFile);
            // 
            // behaviourLabel2
            // 
            behaviourLabel2.AutoSize = true;
            behaviourLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            behaviourLabel2.Location = new System.Drawing.Point(522, 104);
            behaviourLabel2.Name = "behaviourLabel2";
            behaviourLabel2.Size = new System.Drawing.Size(70, 13);
            behaviourLabel2.TabIndex = 104;
            behaviourLabel2.Text = "Behaviour 2: ";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Location = new System.Drawing.Point(331, 61);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 1;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.SetGenderMale);
            this.male.Click += new System.EventHandler(this.SetGenderMale);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(266, 61);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 1;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.SetGenderFemale);
            this.female.Click += new System.EventHandler(this.SetGenderFemale);
            // 
            // studentNameField
            // 
            this.studentNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentNameField.Location = new System.Drawing.Point(85, 63);
            this.studentNameField.Name = "studentNameField";
            this.studentNameField.Size = new System.Drawing.Size(100, 13);
            this.studentNameField.TabIndex = 0;
            this.studentNameField.TextChanged += new System.EventHandler(this.SetStudentName);
            // 
            // reportPreviewLabel
            // 
            this.reportPreviewLabel.AutoSize = true;
            this.reportPreviewLabel.Location = new System.Drawing.Point(38, 217);
            this.reportPreviewLabel.Name = "reportPreviewLabel";
            this.reportPreviewLabel.Size = new System.Drawing.Size(86, 13);
            this.reportPreviewLabel.TabIndex = 100;
            this.reportPreviewLabel.Text = "Preview Report: ";
            // 
            // currentGradeDropDown
            // 
            this.currentGradeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentGradeDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentGradeDropDown.FormattingEnabled = true;
            this.currentGradeDropDown.Items.AddRange(new object[] {
            "4C",
            "4B",
            "4A",
            "5C",
            "5B",
            "5A",
            "6C",
            "6B",
            "6A",
            "7C",
            "7B",
            "7A",
            "8C",
            "8B",
            "8A",
            "9C",
            "9B",
            "9A"});
            this.currentGradeDropDown.Location = new System.Drawing.Point(484, 60);
            this.currentGradeDropDown.Name = "currentGradeDropDown";
            this.currentGradeDropDown.Size = new System.Drawing.Size(62, 21);
            this.currentGradeDropDown.TabIndex = 2;
            this.currentGradeDropDown.SelectedIndexChanged += new System.EventHandler(this.SetCurrentGrade);
            this.currentGradeDropDown.Click += new System.EventHandler(this.SetCurrentGrade);
            // 
            // targetGradeDropDown
            // 
            this.targetGradeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetGradeDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.targetGradeDropDown.FormattingEnabled = true;
            this.targetGradeDropDown.Items.AddRange(new object[] {
            "4C",
            "4B",
            "4A",
            "5C",
            "5B",
            "5A",
            "6C",
            "6B",
            "6A",
            "7C",
            "7B",
            "7A",
            "8C",
            "8B",
            "8A",
            "9C",
            "9B",
            "9A"});
            this.targetGradeDropDown.Location = new System.Drawing.Point(650, 60);
            this.targetGradeDropDown.Name = "targetGradeDropDown";
            this.targetGradeDropDown.Size = new System.Drawing.Size(62, 21);
            this.targetGradeDropDown.TabIndex = 3;
            this.targetGradeDropDown.SelectedIndexChanged += new System.EventHandler(this.SetTargetGrade);
            this.targetGradeDropDown.Click += new System.EventHandler(this.SetTargetGrade);
            // 
            // targetGradeLabel
            // 
            this.targetGradeLabel.AutoSize = true;
            this.targetGradeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.targetGradeLabel.Location = new System.Drawing.Point(568, 63);
            this.targetGradeLabel.Name = "targetGradeLabel";
            this.targetGradeLabel.Size = new System.Drawing.Size(76, 13);
            this.targetGradeLabel.TabIndex = 9;
            this.targetGradeLabel.Text = "Target Grade: ";
            // 
            // currentReport
            // 
            this.currentReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentReport.Location = new System.Drawing.Point(41, 233);
            this.currentReport.Name = "currentReport";
            this.currentReport.Size = new System.Drawing.Size(671, 198);
            this.currentReport.TabIndex = 11;
            this.currentReport.Text = "";
            // 
            // engagement
            // 
            this.engagement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engagement.FormattingEnabled = true;
            this.engagement.Items.AddRange(new object[] {
            "disengaged",
            "distracted",
            "energetic",
            "very quiet",
            "quiet",
            "very engaged"});
            this.engagement.Location = new System.Drawing.Point(117, 101);
            this.engagement.Name = "engagement";
            this.engagement.Size = new System.Drawing.Size(92, 21);
            this.engagement.TabIndex = 4;
            this.engagement.SelectedIndexChanged += new System.EventHandler(this.SetEngagement);
            // 
            // behaviour1
            // 
            this.behaviour1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.behaviour1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.behaviour1.FormattingEnabled = true;
            this.behaviour1.Items.AddRange(new object[] {
            "rude and poorly behaved",
            "rude but sometimes well behaved",
            "polite but sometimes poorly behaved",
            "polite and well behaved"});
            this.behaviour1.Location = new System.Drawing.Point(306, 101);
            this.behaviour1.Name = "behaviour1";
            this.behaviour1.Size = new System.Drawing.Size(191, 21);
            this.behaviour1.TabIndex = 5;
            this.behaviour1.SelectedIndexChanged += new System.EventHandler(this.SetBehaviour1);
            // 
            // completedReportsLable
            // 
            this.completedReportsLable.AutoSize = true;
            this.completedReportsLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completedReportsLable.Location = new System.Drawing.Point(230, 189);
            this.completedReportsLable.Name = "completedReportsLable";
            this.completedReportsLable.Size = new System.Drawing.Size(109, 13);
            this.completedReportsLable.TabIndex = 101;
            this.completedReportsLable.Text = "Completed Reports: 0";
            // 
            // behaviour2
            // 
            this.behaviour2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.behaviour2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.behaviour2.FormattingEnabled = true;
            this.behaviour2.Location = new System.Drawing.Point(598, 101);
            this.behaviour2.Name = "behaviour2";
            this.behaviour2.Size = new System.Drawing.Size(114, 21);
            this.behaviour2.TabIndex = 105;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Location = new System.Drawing.Point(36, 12);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectFileBtn.TabIndex = 106;
            this.SelectFileBtn.Text = "Select File\r\n";
            this.SelectFileBtn.UseVisualStyleBackColor = true;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // recordNumLbl
            // 
            this.recordNumLbl.AutoSize = true;
            this.recordNumLbl.Location = new System.Drawing.Point(130, 17);
            this.recordNumLbl.Name = "recordNumLbl";
            this.recordNumLbl.Size = new System.Drawing.Size(55, 13);
            this.recordNumLbl.TabIndex = 107;
            this.recordNumLbl.Text = "Record #:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 479);
            this.Controls.Add(this.recordNumLbl);
            this.Controls.Add(this.SelectFileBtn);
            this.Controls.Add(this.behaviour2);
            this.Controls.Add(behaviourLabel2);
            this.Controls.Add(saveButton);
            this.Controls.Add(this.completedReportsLable);
            this.Controls.Add(this.behaviour1);
            this.Controls.Add(behaviour1Label);
            this.Controls.Add(engagementLabel);
            this.Controls.Add(this.engagement);
            this.Controls.Add(this.currentReport);
            this.Controls.Add(addReport);
            this.Controls.Add(this.targetGradeLabel);
            this.Controls.Add(currentGradeLabel);
            this.Controls.Add(this.targetGradeDropDown);
            this.Controls.Add(this.currentGradeDropDown);
            this.Controls.Add(this.reportPreviewLabel);
            this.Controls.Add(studentNameLabel);
            this.Controls.Add(this.studentNameField);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Student Report Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.TextBox studentNameField;
        private System.Windows.Forms.Label reportPreviewLabel;
        private System.Windows.Forms.ComboBox currentGradeDropDown;
        private System.Windows.Forms.ComboBox targetGradeDropDown;
        private System.Windows.Forms.Label targetGradeLabel;
        private System.Windows.Forms.RichTextBox currentReport;
        private System.Windows.Forms.ComboBox engagement;
        private System.Windows.Forms.ComboBox behaviour1;
        private System.Windows.Forms.Label completedReportsLable;
        private System.Windows.Forms.ComboBox behaviour2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectFileBtn;
        private System.Windows.Forms.Label recordNumLbl;
    }
}

