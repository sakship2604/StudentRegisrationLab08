namespace StudentRegistrationApp
{
    partial class CourseForm
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
            this.listBoxCoursesList = new System.Windows.Forms.ListBox();
            this.listBoxDepartmentsList = new System.Windows.Forms.ListBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxCourseNumber = new System.Windows.Forms.TextBox();
            this.buttonAddCourseName = new System.Windows.Forms.Button();
            this.buttonUpdateCourse = new System.Windows.Forms.Button();
            this.labelCoursesList = new System.Windows.Forms.Label();
            this.labelDepartmentList = new System.Windows.Forms.Label();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelCourseNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCoursesList
            // 
            this.listBoxCoursesList.FormattingEnabled = true;
            this.listBoxCoursesList.ItemHeight = 16;
            this.listBoxCoursesList.Location = new System.Drawing.Point(200, 12);
            this.listBoxCoursesList.Name = "listBoxCoursesList";
            this.listBoxCoursesList.Size = new System.Drawing.Size(120, 84);
            this.listBoxCoursesList.TabIndex = 0;
            // 
            // listBoxDepartmentsList
            // 
            this.listBoxDepartmentsList.FormattingEnabled = true;
            this.listBoxDepartmentsList.ItemHeight = 16;
            this.listBoxDepartmentsList.Location = new System.Drawing.Point(200, 171);
            this.listBoxDepartmentsList.Name = "listBoxDepartmentsList";
            this.listBoxDepartmentsList.Size = new System.Drawing.Size(120, 84);
            this.listBoxDepartmentsList.TabIndex = 1;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(200, 298);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(100, 22);
            this.textBoxCourseName.TabIndex = 2;
            // 
            // textBoxCourseNumber
            // 
            this.textBoxCourseNumber.Location = new System.Drawing.Point(200, 341);
            this.textBoxCourseNumber.Name = "textBoxCourseNumber";
            this.textBoxCourseNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxCourseNumber.TabIndex = 3;
            // 
            // buttonAddCourseName
            // 
            this.buttonAddCourseName.Location = new System.Drawing.Point(106, 389);
            this.buttonAddCourseName.Name = "buttonAddCourseName";
            this.buttonAddCourseName.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCourseName.TabIndex = 4;
            this.buttonAddCourseName.Text = "Add";
            this.buttonAddCourseName.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCourse
            // 
            this.buttonUpdateCourse.Location = new System.Drawing.Point(225, 389);
            this.buttonUpdateCourse.Name = "buttonUpdateCourse";
            this.buttonUpdateCourse.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateCourse.TabIndex = 5;
            this.buttonUpdateCourse.Text = "Update";
            this.buttonUpdateCourse.UseVisualStyleBackColor = true;
            // 
            // labelCoursesList
            // 
            this.labelCoursesList.AutoSize = true;
            this.labelCoursesList.Location = new System.Drawing.Point(65, 13);
            this.labelCoursesList.Name = "labelCoursesList";
            this.labelCoursesList.Size = new System.Drawing.Size(60, 17);
            this.labelCoursesList.TabIndex = 6;
            this.labelCoursesList.Text = "Courses";
            // 
            // labelDepartmentList
            // 
            this.labelDepartmentList.AutoSize = true;
            this.labelDepartmentList.Location = new System.Drawing.Point(65, 171);
            this.labelDepartmentList.Name = "labelDepartmentList";
            this.labelDepartmentList.Size = new System.Drawing.Size(89, 17);
            this.labelDepartmentList.TabIndex = 7;
            this.labelDepartmentList.Text = "Departments";
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(68, 301);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(94, 17);
            this.labelCourseName.TabIndex = 8;
            this.labelCourseName.Text = "Course Name";
            // 
            // labelCourseNumber
            // 
            this.labelCourseNumber.AutoSize = true;
            this.labelCourseNumber.Location = new System.Drawing.Point(71, 346);
            this.labelCourseNumber.Name = "labelCourseNumber";
            this.labelCourseNumber.Size = new System.Drawing.Size(107, 17);
            this.labelCourseNumber.TabIndex = 9;
            this.labelCourseNumber.Text = "Course Number";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCourseNumber);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.labelDepartmentList);
            this.Controls.Add(this.labelCoursesList);
            this.Controls.Add(this.buttonUpdateCourse);
            this.Controls.Add(this.buttonAddCourseName);
            this.Controls.Add(this.textBoxCourseNumber);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.listBoxDepartmentsList);
            this.Controls.Add(this.listBoxCoursesList);
            this.Name = "CourseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCoursesList;
        private System.Windows.Forms.ListBox listBoxDepartmentsList;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxCourseNumber;
        private System.Windows.Forms.Button buttonAddCourseName;
        private System.Windows.Forms.Button buttonUpdateCourse;
        private System.Windows.Forms.Label labelCoursesList;
        private System.Windows.Forms.Label labelDepartmentList;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Label labelCourseNumber;
    }
}