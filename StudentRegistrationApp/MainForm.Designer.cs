namespace StudentRegistrationApp
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.dataGridViewRegistration = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonCourse = new System.Windows.Forms.Button();
            this.buttonDepartment = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelCourses = new System.Windows.Forms.Label();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeight = 29;
            this.dataGridViewStudents.Location = new System.Drawing.Point(24, 91);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new System.Drawing.Size(566, 150);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(24, 349);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(566, 150);
            this.dataGridViewCourses.TabIndex = 1;
            // 
            // dataGridViewRegistration
            // 
            this.dataGridViewRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistration.Location = new System.Drawing.Point(24, 556);
            this.dataGridViewRegistration.Name = "dataGridViewRegistration";
            this.dataGridViewRegistration.RowHeadersWidth = 51;
            this.dataGridViewRegistration.RowTemplate.Height = 24;
            this.dataGridViewRegistration.Size = new System.Drawing.Size(566, 150);
            this.dataGridViewRegistration.TabIndex = 2;
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(742, 91);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.RowHeadersWidth = 51;
            this.dataGridViewDepartment.RowTemplate.Height = 24;
            this.dataGridViewDepartment.Size = new System.Drawing.Size(368, 150);
            this.dataGridViewDepartment.TabIndex = 3;
            // 
            // buttonStudent
            // 
            this.buttonStudent.Location = new System.Drawing.Point(620, 157);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(93, 63);
            this.buttonStudent.TabIndex = 4;
            this.buttonStudent.Text = "Add or Update Stduents";
            this.buttonStudent.UseVisualStyleBackColor = true;
            // 
            // buttonCourse
            // 
            this.buttonCourse.Location = new System.Drawing.Point(620, 400);
            this.buttonCourse.Name = "buttonCourse";
            this.buttonCourse.Size = new System.Drawing.Size(93, 67);
            this.buttonCourse.TabIndex = 5;
            this.buttonCourse.Text = "Add or Update Course";
            this.buttonCourse.UseVisualStyleBackColor = true;
            // 
            // buttonDepartment
            // 
            this.buttonDepartment.Location = new System.Drawing.Point(1126, 157);
            this.buttonDepartment.Name = "buttonDepartment";
            this.buttonDepartment.Size = new System.Drawing.Size(103, 63);
            this.buttonDepartment.TabIndex = 6;
            this.buttonDepartment.Text = "Add or Update Department";
            this.buttonDepartment.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(711, 556);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 41);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(711, 631);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(75, 39);
            this.buttonDrop.TabIndex = 8;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStudents.Location = new System.Drawing.Point(24, 50);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(66, 19);
            this.labelStudents.TabIndex = 9;
            this.labelStudents.Text = "Students";
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCourses.Location = new System.Drawing.Point(27, 306);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(62, 19);
            this.labelCourses.TabIndex = 10;
            this.labelCourses.Text = "Courses";
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegistration.Location = new System.Drawing.Point(24, 520);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(86, 19);
            this.labelRegistration.TabIndex = 11;
            this.labelRegistration.Text = "Registration";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDepartment.Location = new System.Drawing.Point(742, 50);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(84, 19);
            this.labelDepartment.TabIndex = 12;
            this.labelDepartment.Text = "Department";
            // 
            // labelDescription
            // 
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescription.Location = new System.Drawing.Point(899, 556);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(161, 121);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Register by selecting students and courses and hit register.. Drop by selecting r" +
    "egister and then hit drop button.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 794);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelRegistration);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonDepartment);
            this.Controls.Add(this.buttonCourse);
            this.Controls.Add(this.buttonStudent);
            this.Controls.Add(this.dataGridViewDepartment);
            this.Controls.Add(this.dataGridViewRegistration);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.DataGridView dataGridViewRegistration;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonCourse;
        private System.Windows.Forms.Button buttonDepartment;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Label labelCourses;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelDescription;
    }
}

