namespace StudentRegistrationApp
{
    partial class DepartmentForm
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
            this.listBoxDepartment = new System.Windows.Forms.ListBox();
            this.textBoxDepartmentCode = new System.Windows.Forms.TextBox();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.buttonDepartmentAdd = new System.Windows.Forms.Button();
            this.buttonDepartmentUpdate = new System.Windows.Forms.Button();
            this.labelDepartmentCode = new System.Windows.Forms.Label();
            this.labelDepartmentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.FormattingEnabled = true;
            this.listBoxDepartment.ItemHeight = 16;
            this.listBoxDepartment.Location = new System.Drawing.Point(37, 26);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(120, 84);
            this.listBoxDepartment.TabIndex = 0;
            // 
            // textBoxDepartmentCode
            // 
            this.textBoxDepartmentCode.Location = new System.Drawing.Point(37, 179);
            this.textBoxDepartmentCode.Name = "textBoxDepartmentCode";
            this.textBoxDepartmentCode.Size = new System.Drawing.Size(100, 22);
            this.textBoxDepartmentCode.TabIndex = 1;
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(37, 246);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(100, 22);
            this.textBoxDepartmentName.TabIndex = 2;
            // 
            // buttonDepartmentAdd
            // 
            this.buttonDepartmentAdd.Location = new System.Drawing.Point(37, 306);
            this.buttonDepartmentAdd.Name = "buttonDepartmentAdd";
            this.buttonDepartmentAdd.Size = new System.Drawing.Size(76, 31);
            this.buttonDepartmentAdd.TabIndex = 3;
            this.buttonDepartmentAdd.Text = "Add";
            this.buttonDepartmentAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDepartmentUpdate
            // 
            this.buttonDepartmentUpdate.Location = new System.Drawing.Point(189, 306);
            this.buttonDepartmentUpdate.Name = "buttonDepartmentUpdate";
            this.buttonDepartmentUpdate.Size = new System.Drawing.Size(80, 31);
            this.buttonDepartmentUpdate.TabIndex = 4;
            this.buttonDepartmentUpdate.Text = "Update";
            this.buttonDepartmentUpdate.UseVisualStyleBackColor = true;
            // 
            // labelDepartmentCode
            // 
            this.labelDepartmentCode.AutoSize = true;
            this.labelDepartmentCode.Location = new System.Drawing.Point(34, 136);
            this.labelDepartmentCode.Name = "labelDepartmentCode";
            this.labelDepartmentCode.Size = new System.Drawing.Size(119, 17);
            this.labelDepartmentCode.TabIndex = 6;
            this.labelDepartmentCode.Text = "Department Code";
            // 
            // labelDepartmentName
            // 
            this.labelDepartmentName.AutoSize = true;
            this.labelDepartmentName.Location = new System.Drawing.Point(37, 223);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(123, 17);
            this.labelDepartmentName.TabIndex = 7;
            this.labelDepartmentName.Text = "Department Name";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDepartmentName);
            this.Controls.Add(this.labelDepartmentCode);
            this.Controls.Add(this.buttonDepartmentUpdate);
            this.Controls.Add(this.buttonDepartmentAdd);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.textBoxDepartmentCode);
            this.Controls.Add(this.listBoxDepartment);
            this.Name = "DepartmentForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDepartment;
        private System.Windows.Forms.TextBox textBoxDepartmentCode;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Button buttonDepartmentAdd;
        private System.Windows.Forms.Button buttonDepartmentUpdate;
        private System.Windows.Forms.Label labelDepartmentCode;
        
        private System.Windows.Forms.Label labelDepartmentName;
    }
}