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
            this.outerTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bottomTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.topTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomLeftPanel = new System.Windows.Forms.Panel();
            this.bottomRightPanel = new System.Windows.Forms.Panel();
            this.topThirdPanel = new System.Windows.Forms.Panel();
            this.topMiddlePanel = new System.Windows.Forms.Panel();
            this.topFirstPanel = new System.Windows.Forms.Panel();
            this.reportPreviewTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveReportTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.studentDetailsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.studentNamePanel = new System.Windows.Forms.Panel();
            this.studentGenderPanel = new System.Windows.Forms.Panel();
            this.currentGradePanel = new System.Windows.Forms.Panel();
            this.targetGradePanel = new System.Windows.Forms.Panel();
            this.studentBehaviourTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.engagementPanel = new System.Windows.Forms.Panel();
            this.behaviour1Panel = new System.Windows.Forms.Panel();
            this.behaviour2Panel = new System.Windows.Forms.Panel();
            genderLabel = new System.Windows.Forms.Label();
            studentNameLabel = new System.Windows.Forms.Label();
            currentGradeLabel = new System.Windows.Forms.Label();
            addReport = new System.Windows.Forms.Button();
            engagementLabel = new System.Windows.Forms.Label();
            behaviour1Label = new System.Windows.Forms.Label();
            saveButton = new System.Windows.Forms.Button();
            behaviourLabel2 = new System.Windows.Forms.Label();
            this.outerTablePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.bottomTablePanel.SuspendLayout();
            this.topTablePanel.SuspendLayout();
            this.bottomLeftPanel.SuspendLayout();
            this.bottomRightPanel.SuspendLayout();
            this.topThirdPanel.SuspendLayout();
            this.topMiddlePanel.SuspendLayout();
            this.topFirstPanel.SuspendLayout();
            this.reportPreviewTablePanel.SuspendLayout();
            this.saveReportTablePanel.SuspendLayout();
            this.studentDetailsTablePanel.SuspendLayout();
            this.studentNamePanel.SuspendLayout();
            this.studentGenderPanel.SuspendLayout();
            this.currentGradePanel.SuspendLayout();
            this.targetGradePanel.SuspendLayout();
            this.studentBehaviourTablePanel.SuspendLayout();
            this.engagementPanel.SuspendLayout();
            this.behaviour1Panel.SuspendLayout();
            this.behaviour2Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            genderLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(9, 12);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(56, 16);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender: ";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentNameLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentNameLabel.Location = new System.Drawing.Point(12, 12);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(47, 16);
            studentNameLabel.TabIndex = 4;
            studentNameLabel.Text = "Name: ";
            // 
            // currentGradeLabel
            // 
            currentGradeLabel.AutoSize = true;
            currentGradeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            currentGradeLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentGradeLabel.Location = new System.Drawing.Point(7, 12);
            currentGradeLabel.Name = "currentGradeLabel";
            currentGradeLabel.Size = new System.Drawing.Size(93, 16);
            currentGradeLabel.TabIndex = 8;
            currentGradeLabel.Text = "Current Grade: ";
            // 
            // addReport
            // 
            addReport.Dock = System.Windows.Forms.DockStyle.Top;
            addReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addReport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addReport.Location = new System.Drawing.Point(3, 228);
            addReport.Name = "addReport";
            addReport.Size = new System.Drawing.Size(122, 23);
            addReport.TabIndex = 10;
            addReport.Text = "Add Report";
            addReport.UseVisualStyleBackColor = true;
            addReport.Click += new System.EventHandler(this.AddReportToList);
            // 
            // engagementLabel
            // 
            engagementLabel.AutoSize = true;
            engagementLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            engagementLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            engagementLabel.Location = new System.Drawing.Point(12, 18);
            engagementLabel.Name = "engagementLabel";
            engagementLabel.Size = new System.Drawing.Size(84, 16);
            engagementLabel.TabIndex = 13;
            engagementLabel.Text = "Engagement: ";
            // 
            // behaviour1Label
            // 
            behaviour1Label.AutoSize = true;
            behaviour1Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            behaviour1Label.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            behaviour1Label.Location = new System.Drawing.Point(15, 17);
            behaviour1Label.Name = "behaviour1Label";
            behaviour1Label.Size = new System.Drawing.Size(78, 16);
            behaviour1Label.TabIndex = 14;
            behaviour1Label.Text = "Behaviour 1: ";
            // 
            // saveButton
            // 
            saveButton.Dock = System.Windows.Forms.DockStyle.Top;
            saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            saveButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            saveButton.Location = new System.Drawing.Point(3, 257);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(122, 23);
            saveButton.TabIndex = 103;
            saveButton.Text = "Save As";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += new System.EventHandler(this.SaveReportsToFile);
            // 
            // behaviourLabel2
            // 
            behaviourLabel2.AutoSize = true;
            behaviourLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            behaviourLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            behaviourLabel2.Location = new System.Drawing.Point(20, 17);
            behaviourLabel2.Name = "behaviourLabel2";
            behaviourLabel2.Size = new System.Drawing.Size(78, 16);
            behaviourLabel2.TabIndex = 104;
            behaviourLabel2.Text = "Behaviour 2: ";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(77, 33);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(54, 20);
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
            this.female.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(77, 10);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(65, 20);
            this.female.TabIndex = 1;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.SetGenderFemale);
            this.female.Click += new System.EventHandler(this.SetGenderFemale);
            // 
            // studentNameField
            // 
            this.studentNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentNameField.Location = new System.Drawing.Point(65, 15);
            this.studentNameField.Name = "studentNameField";
            this.studentNameField.Size = new System.Drawing.Size(100, 13);
            this.studentNameField.TabIndex = 0;
            this.studentNameField.TextChanged += new System.EventHandler(this.SetStudentName);
            // 
            // reportPreviewLabel
            // 
            this.reportPreviewLabel.AutoSize = true;
            this.reportPreviewLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportPreviewLabel.Location = new System.Drawing.Point(3, 0);
            this.reportPreviewLabel.Name = "reportPreviewLabel";
            this.reportPreviewLabel.Size = new System.Drawing.Size(130, 19);
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
            this.currentGradeDropDown.Location = new System.Drawing.Point(106, 10);
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
            this.targetGradeDropDown.Location = new System.Drawing.Point(96, 12);
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
            this.targetGradeLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetGradeLabel.Location = new System.Drawing.Point(3, 14);
            this.targetGradeLabel.Name = "targetGradeLabel";
            this.targetGradeLabel.Size = new System.Drawing.Size(87, 16);
            this.targetGradeLabel.TabIndex = 9;
            this.targetGradeLabel.Text = "Target Grade: ";
            // 
            // currentReport
            // 
            this.currentReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentReport.Location = new System.Drawing.Point(3, 38);
            this.currentReport.Name = "currentReport";
            this.currentReport.Size = new System.Drawing.Size(614, 242);
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
            this.engagement.Location = new System.Drawing.Point(98, 15);
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
            this.behaviour1.Location = new System.Drawing.Point(99, 15);
            this.behaviour1.Name = "behaviour1";
            this.behaviour1.Size = new System.Drawing.Size(144, 21);
            this.behaviour1.TabIndex = 5;
            this.behaviour1.SelectedIndexChanged += new System.EventHandler(this.SetBehaviour1);
            // 
            // completedReportsLable
            // 
            this.completedReportsLable.AutoSize = true;
            this.completedReportsLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.completedReportsLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completedReportsLable.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedReportsLable.Location = new System.Drawing.Point(3, 38);
            this.completedReportsLable.Name = "completedReportsLable";
            this.completedReportsLable.Size = new System.Drawing.Size(122, 32);
            this.completedReportsLable.TabIndex = 101;
            this.completedReportsLable.Text = "Completed Reports: 0";
            this.completedReportsLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // behaviour2
            // 
            this.behaviour2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.behaviour2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.behaviour2.FormattingEnabled = true;
            this.behaviour2.Location = new System.Drawing.Point(104, 15);
            this.behaviour2.Name = "behaviour2";
            this.behaviour2.Size = new System.Drawing.Size(144, 21);
            this.behaviour2.TabIndex = 105;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileBtn.Location = new System.Drawing.Point(7, 12);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(84, 23);
            this.SelectFileBtn.TabIndex = 106;
            this.SelectFileBtn.Text = "Select File\r\n";
            this.SelectFileBtn.UseVisualStyleBackColor = true;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // recordNumLbl
            // 
            this.recordNumLbl.AutoSize = true;
            this.recordNumLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordNumLbl.Location = new System.Drawing.Point(106, 15);
            this.recordNumLbl.Name = "recordNumLbl";
            this.recordNumLbl.Size = new System.Drawing.Size(79, 18);
            this.recordNumLbl.TabIndex = 107;
            this.recordNumLbl.Text = "Record #:";
            // 
            // outerTablePanel
            // 
            this.outerTablePanel.ColumnCount = 1;
            this.outerTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerTablePanel.Controls.Add(this.topPanel, 0, 0);
            this.outerTablePanel.Controls.Add(this.bottomPanel, 0, 1);
            this.outerTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerTablePanel.Location = new System.Drawing.Point(0, 0);
            this.outerTablePanel.Name = "outerTablePanel";
            this.outerTablePanel.RowCount = 2;
            this.outerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.62213F));
            this.outerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.37787F));
            this.outerTablePanel.Size = new System.Drawing.Size(766, 479);
            this.outerTablePanel.TabIndex = 108;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.topTablePanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(760, 178);
            this.topPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.bottomTablePanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(3, 187);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(760, 289);
            this.bottomPanel.TabIndex = 1;
            // 
            // bottomTablePanel
            // 
            this.bottomTablePanel.ColumnCount = 2;
            this.bottomTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.36842F));
            this.bottomTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.63158F));
            this.bottomTablePanel.Controls.Add(this.bottomLeftPanel, 0, 0);
            this.bottomTablePanel.Controls.Add(this.bottomRightPanel, 1, 0);
            this.bottomTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTablePanel.Location = new System.Drawing.Point(0, 0);
            this.bottomTablePanel.Name = "bottomTablePanel";
            this.bottomTablePanel.RowCount = 1;
            this.bottomTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomTablePanel.Size = new System.Drawing.Size(760, 289);
            this.bottomTablePanel.TabIndex = 0;
            // 
            // topTablePanel
            // 
            this.topTablePanel.ColumnCount = 1;
            this.topTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.topTablePanel.Controls.Add(this.topThirdPanel, 0, 2);
            this.topTablePanel.Controls.Add(this.topMiddlePanel, 0, 1);
            this.topTablePanel.Controls.Add(this.topFirstPanel, 0, 0);
            this.topTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTablePanel.Location = new System.Drawing.Point(0, 0);
            this.topTablePanel.Name = "topTablePanel";
            this.topTablePanel.RowCount = 3;
            this.topTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.8427F));
            this.topTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.64045F));
            this.topTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.51685F));
            this.topTablePanel.Size = new System.Drawing.Size(760, 178);
            this.topTablePanel.TabIndex = 0;
            // 
            // bottomLeftPanel
            // 
            this.bottomLeftPanel.Controls.Add(this.reportPreviewTablePanel);
            this.bottomLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLeftPanel.Location = new System.Drawing.Point(3, 3);
            this.bottomLeftPanel.Name = "bottomLeftPanel";
            this.bottomLeftPanel.Size = new System.Drawing.Size(620, 283);
            this.bottomLeftPanel.TabIndex = 0;
            // 
            // bottomRightPanel
            // 
            this.bottomRightPanel.Controls.Add(this.saveReportTablePanel);
            this.bottomRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRightPanel.Location = new System.Drawing.Point(629, 3);
            this.bottomRightPanel.Name = "bottomRightPanel";
            this.bottomRightPanel.Size = new System.Drawing.Size(128, 283);
            this.bottomRightPanel.TabIndex = 1;
            // 
            // topThirdPanel
            // 
            this.topThirdPanel.Controls.Add(this.studentBehaviourTablePanel);
            this.topThirdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topThirdPanel.Location = new System.Drawing.Point(3, 116);
            this.topThirdPanel.Name = "topThirdPanel";
            this.topThirdPanel.Size = new System.Drawing.Size(754, 59);
            this.topThirdPanel.TabIndex = 0;
            // 
            // topMiddlePanel
            // 
            this.topMiddlePanel.Controls.Add(this.studentDetailsTablePanel);
            this.topMiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topMiddlePanel.Location = new System.Drawing.Point(3, 49);
            this.topMiddlePanel.Name = "topMiddlePanel";
            this.topMiddlePanel.Size = new System.Drawing.Size(754, 61);
            this.topMiddlePanel.TabIndex = 1;
            // 
            // topFirstPanel
            // 
            this.topFirstPanel.Controls.Add(this.SelectFileBtn);
            this.topFirstPanel.Controls.Add(this.recordNumLbl);
            this.topFirstPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topFirstPanel.Location = new System.Drawing.Point(3, 3);
            this.topFirstPanel.Name = "topFirstPanel";
            this.topFirstPanel.Size = new System.Drawing.Size(754, 40);
            this.topFirstPanel.TabIndex = 2;
            // 
            // reportPreviewTablePanel
            // 
            this.reportPreviewTablePanel.ColumnCount = 1;
            this.reportPreviewTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reportPreviewTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.reportPreviewTablePanel.Controls.Add(this.reportPreviewLabel, 0, 0);
            this.reportPreviewTablePanel.Controls.Add(this.currentReport, 0, 1);
            this.reportPreviewTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPreviewTablePanel.Location = new System.Drawing.Point(0, 0);
            this.reportPreviewTablePanel.Name = "reportPreviewTablePanel";
            this.reportPreviewTablePanel.RowCount = 2;
            this.reportPreviewTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7193F));
            this.reportPreviewTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.2807F));
            this.reportPreviewTablePanel.Size = new System.Drawing.Size(620, 283);
            this.reportPreviewTablePanel.TabIndex = 0;
            // 
            // saveReportTablePanel
            // 
            this.saveReportTablePanel.ColumnCount = 1;
            this.saveReportTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.saveReportTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.saveReportTablePanel.Controls.Add(this.completedReportsLable, 0, 1);
            this.saveReportTablePanel.Controls.Add(saveButton, 0, 4);
            this.saveReportTablePanel.Controls.Add(addReport, 0, 3);
            this.saveReportTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveReportTablePanel.Location = new System.Drawing.Point(0, 0);
            this.saveReportTablePanel.Name = "saveReportTablePanel";
            this.saveReportTablePanel.RowCount = 5;
            this.saveReportTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.42756F));
            this.saveReportTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.14841F));
            this.saveReportTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.92933F));
            this.saveReportTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.24735F));
            this.saveReportTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.893993F));
            this.saveReportTablePanel.Size = new System.Drawing.Size(128, 283);
            this.saveReportTablePanel.TabIndex = 0;
            // 
            // studentDetailsTablePanel
            // 
            this.studentDetailsTablePanel.ColumnCount = 4;
            this.studentDetailsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.studentDetailsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.studentDetailsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.studentDetailsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.studentDetailsTablePanel.Controls.Add(this.studentNamePanel, 0, 0);
            this.studentDetailsTablePanel.Controls.Add(this.studentGenderPanel, 1, 0);
            this.studentDetailsTablePanel.Controls.Add(this.currentGradePanel, 2, 0);
            this.studentDetailsTablePanel.Controls.Add(this.targetGradePanel, 3, 0);
            this.studentDetailsTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDetailsTablePanel.Location = new System.Drawing.Point(0, 0);
            this.studentDetailsTablePanel.Name = "studentDetailsTablePanel";
            this.studentDetailsTablePanel.RowCount = 1;
            this.studentDetailsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.studentDetailsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.studentDetailsTablePanel.Size = new System.Drawing.Size(754, 61);
            this.studentDetailsTablePanel.TabIndex = 0;
            // 
            // studentNamePanel
            // 
            this.studentNamePanel.Controls.Add(studentNameLabel);
            this.studentNamePanel.Controls.Add(this.studentNameField);
            this.studentNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentNamePanel.Location = new System.Drawing.Point(3, 3);
            this.studentNamePanel.Name = "studentNamePanel";
            this.studentNamePanel.Size = new System.Drawing.Size(182, 55);
            this.studentNamePanel.TabIndex = 0;
            // 
            // studentGenderPanel
            // 
            this.studentGenderPanel.Controls.Add(genderLabel);
            this.studentGenderPanel.Controls.Add(this.female);
            this.studentGenderPanel.Controls.Add(this.male);
            this.studentGenderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGenderPanel.Location = new System.Drawing.Point(191, 3);
            this.studentGenderPanel.Name = "studentGenderPanel";
            this.studentGenderPanel.Size = new System.Drawing.Size(182, 55);
            this.studentGenderPanel.TabIndex = 1;
            // 
            // currentGradePanel
            // 
            this.currentGradePanel.Controls.Add(currentGradeLabel);
            this.currentGradePanel.Controls.Add(this.currentGradeDropDown);
            this.currentGradePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentGradePanel.Location = new System.Drawing.Point(379, 3);
            this.currentGradePanel.Name = "currentGradePanel";
            this.currentGradePanel.Size = new System.Drawing.Size(182, 55);
            this.currentGradePanel.TabIndex = 2;
            // 
            // targetGradePanel
            // 
            this.targetGradePanel.Controls.Add(this.targetGradeLabel);
            this.targetGradePanel.Controls.Add(this.targetGradeDropDown);
            this.targetGradePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetGradePanel.Location = new System.Drawing.Point(567, 3);
            this.targetGradePanel.Name = "targetGradePanel";
            this.targetGradePanel.Size = new System.Drawing.Size(184, 55);
            this.targetGradePanel.TabIndex = 3;
            // 
            // studentBehaviourTablePanel
            // 
            this.studentBehaviourTablePanel.ColumnCount = 3;
            this.studentBehaviourTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98409F));
            this.studentBehaviourTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.88064F));
            this.studentBehaviourTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.00265F));
            this.studentBehaviourTablePanel.Controls.Add(this.engagementPanel, 0, 0);
            this.studentBehaviourTablePanel.Controls.Add(this.behaviour1Panel, 1, 0);
            this.studentBehaviourTablePanel.Controls.Add(this.behaviour2Panel, 2, 0);
            this.studentBehaviourTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentBehaviourTablePanel.Location = new System.Drawing.Point(0, 0);
            this.studentBehaviourTablePanel.Name = "studentBehaviourTablePanel";
            this.studentBehaviourTablePanel.RowCount = 1;
            this.studentBehaviourTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.studentBehaviourTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.studentBehaviourTablePanel.Size = new System.Drawing.Size(754, 59);
            this.studentBehaviourTablePanel.TabIndex = 0;
            // 
            // engagementPanel
            // 
            this.engagementPanel.Controls.Add(engagementLabel);
            this.engagementPanel.Controls.Add(this.engagement);
            this.engagementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.engagementPanel.Location = new System.Drawing.Point(3, 3);
            this.engagementPanel.Name = "engagementPanel";
            this.engagementPanel.Size = new System.Drawing.Size(205, 53);
            this.engagementPanel.TabIndex = 0;
            // 
            // behaviour1Panel
            // 
            this.behaviour1Panel.Controls.Add(this.behaviour1);
            this.behaviour1Panel.Controls.Add(behaviour1Label);
            this.behaviour1Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.behaviour1Panel.Location = new System.Drawing.Point(214, 3);
            this.behaviour1Panel.Name = "behaviour1Panel";
            this.behaviour1Panel.Size = new System.Drawing.Size(257, 53);
            this.behaviour1Panel.TabIndex = 1;
            // 
            // behaviour2Panel
            // 
            this.behaviour2Panel.Controls.Add(this.behaviour2);
            this.behaviour2Panel.Controls.Add(behaviourLabel2);
            this.behaviour2Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.behaviour2Panel.Location = new System.Drawing.Point(477, 3);
            this.behaviour2Panel.Name = "behaviour2Panel";
            this.behaviour2Panel.Size = new System.Drawing.Size(274, 53);
            this.behaviour2Panel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 479);
            this.Controls.Add(this.outerTablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Student Report Generator";
            this.outerTablePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomTablePanel.ResumeLayout(false);
            this.topTablePanel.ResumeLayout(false);
            this.bottomLeftPanel.ResumeLayout(false);
            this.bottomRightPanel.ResumeLayout(false);
            this.topThirdPanel.ResumeLayout(false);
            this.topMiddlePanel.ResumeLayout(false);
            this.topFirstPanel.ResumeLayout(false);
            this.topFirstPanel.PerformLayout();
            this.reportPreviewTablePanel.ResumeLayout(false);
            this.reportPreviewTablePanel.PerformLayout();
            this.saveReportTablePanel.ResumeLayout(false);
            this.saveReportTablePanel.PerformLayout();
            this.studentDetailsTablePanel.ResumeLayout(false);
            this.studentNamePanel.ResumeLayout(false);
            this.studentNamePanel.PerformLayout();
            this.studentGenderPanel.ResumeLayout(false);
            this.studentGenderPanel.PerformLayout();
            this.currentGradePanel.ResumeLayout(false);
            this.currentGradePanel.PerformLayout();
            this.targetGradePanel.ResumeLayout(false);
            this.targetGradePanel.PerformLayout();
            this.studentBehaviourTablePanel.ResumeLayout(false);
            this.engagementPanel.ResumeLayout(false);
            this.engagementPanel.PerformLayout();
            this.behaviour1Panel.ResumeLayout(false);
            this.behaviour1Panel.PerformLayout();
            this.behaviour2Panel.ResumeLayout(false);
            this.behaviour2Panel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel outerTablePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TableLayoutPanel topTablePanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.TableLayoutPanel bottomTablePanel;
        private System.Windows.Forms.Panel bottomLeftPanel;
        private System.Windows.Forms.Panel bottomRightPanel;
        private System.Windows.Forms.Panel topThirdPanel;
        private System.Windows.Forms.TableLayoutPanel studentBehaviourTablePanel;
        private System.Windows.Forms.Panel engagementPanel;
        private System.Windows.Forms.Panel behaviour1Panel;
        private System.Windows.Forms.Panel behaviour2Panel;
        private System.Windows.Forms.Panel topMiddlePanel;
        private System.Windows.Forms.TableLayoutPanel studentDetailsTablePanel;
        private System.Windows.Forms.Panel studentNamePanel;
        private System.Windows.Forms.Panel studentGenderPanel;
        private System.Windows.Forms.Panel currentGradePanel;
        private System.Windows.Forms.Panel targetGradePanel;
        private System.Windows.Forms.Panel topFirstPanel;
        private System.Windows.Forms.TableLayoutPanel reportPreviewTablePanel;
        private System.Windows.Forms.TableLayoutPanel saveReportTablePanel;
    }
}

