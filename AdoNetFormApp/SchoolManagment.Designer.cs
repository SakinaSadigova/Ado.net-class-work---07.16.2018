namespace AdoNetFormApp
{
    partial class SchoolManagment
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowTeacher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowClass = new System.Windows.Forms.Button();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.txtStudCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwTeachers = new System.Windows.Forms.DataGridView();
            this.dgwClasses = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwTeachers);
            this.panel2.Controls.Add(this.btnShowTeacher);
            this.panel2.Controls.Add(this.btnAddTeacher);
            this.panel2.Controls.Add(this.txtTeacherName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(441, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 470);
            this.panel2.TabIndex = 3;
            // 
            // btnShowTeacher
            // 
            this.btnShowTeacher.Location = new System.Drawing.Point(7, 148);
            this.btnShowTeacher.Name = "btnShowTeacher";
            this.btnShowTeacher.Size = new System.Drawing.Size(122, 23);
            this.btnShowTeacher.TabIndex = 9;
            this.btnShowTeacher.Text = "Show Teachers";
            this.btnShowTeacher.UseVisualStyleBackColor = true;
            this.btnShowTeacher.Click += new System.EventHandler(this.btnShowTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(96, 52);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(274, 23);
            this.btnAddTeacher.TabIndex = 5;
            this.btnAddTeacher.Text = "Add teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(96, 17);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(274, 20);
            this.txtTeacherName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teacher Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwClasses);
            this.panel1.Controls.Add(this.btnShowClass);
            this.panel1.Controls.Add(this.cmbTeacher);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddClass);
            this.panel1.Controls.Add(this.txtStudCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtClassName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 470);
            this.panel1.TabIndex = 2;
            // 
            // btnShowClass
            // 
            this.btnShowClass.Location = new System.Drawing.Point(6, 148);
            this.btnShowClass.Name = "btnShowClass";
            this.btnShowClass.Size = new System.Drawing.Size(122, 23);
            this.btnShowClass.TabIndex = 7;
            this.btnShowClass.Text = "Show classes";
            this.btnShowClass.UseVisualStyleBackColor = true;
            this.btnShowClass.Click += new System.EventHandler(this.btnShowClass_Click);
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(124, 88);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(296, 21);
            this.cmbTeacher.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Teacher Name";
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(180, 115);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(240, 23);
            this.btnAddClass.TabIndex = 4;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // txtStudCount
            // 
            this.txtStudCount.Location = new System.Drawing.Point(124, 52);
            this.txtStudCount.Name = "txtStudCount";
            this.txtStudCount.Size = new System.Drawing.Size(296, 20);
            this.txtStudCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Count";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(124, 17);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(296, 20);
            this.txtClassName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Name";
            // 
            // dgwTeachers
            // 
            this.dgwTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeachers.Location = new System.Drawing.Point(7, 196);
            this.dgwTeachers.Name = "dgwTeachers";
            this.dgwTeachers.Size = new System.Drawing.Size(363, 271);
            this.dgwTeachers.TabIndex = 10;
            // 
            // dgwClasses
            // 
            this.dgwClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClasses.Location = new System.Drawing.Point(6, 196);
            this.dgwClasses.Name = "dgwClasses";
            this.dgwClasses.RowHeadersVisible = false;
            this.dgwClasses.Size = new System.Drawing.Size(414, 271);
            this.dgwClasses.TabIndex = 11;
            // 
            // SchoolManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SchoolManagment";
            this.Text = "SchoolManagment";
            this.Load += new System.EventHandler(this.SchoolManagment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShowTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowClass;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TextBox txtStudCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwTeachers;
        private System.Windows.Forms.DataGridView dgwClasses;
    }
}