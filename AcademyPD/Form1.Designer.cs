namespace AcademyPD
{
    partial class Form1
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
            this.tabGroups = new System.Windows.Forms.TabControl();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.rbGroups = new System.Windows.Forms.RadioButton();
            this.rbStud = new System.Windows.Forms.RadioButton();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.lblStudCount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.tabPageTeacher = new System.Windows.Forms.TabPage();
            this.tabPGroups = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.tabGroups.SuspendLayout();
            this.tabPageStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.tabPGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGroups
            // 
            this.tabGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGroups.Controls.Add(this.tabPageStudent);
            this.tabGroups.Controls.Add(this.tabPGroups);
            this.tabGroups.Controls.Add(this.tabPageTeacher);
            this.tabGroups.Location = new System.Drawing.Point(29, 25);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.SelectedIndex = 0;
            this.tabGroups.Size = new System.Drawing.Size(719, 413);
            this.tabGroups.TabIndex = 0;
            // 
            // tabPageStudent
            // 
            this.tabPageStudent.Controls.Add(this.rbGroups);
            this.tabPageStudent.Controls.Add(this.rbStud);
            this.tabPageStudent.Controls.Add(this.cbDirection);
            this.tabPageStudent.Controls.Add(this.lblStudCount);
            this.tabPageStudent.Controls.Add(this.btnAdd);
            this.tabPageStudent.Controls.Add(this.dgwStudents);
            this.tabPageStudent.Controls.Add(this.cbGroup);
            this.tabPageStudent.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudent.Size = new System.Drawing.Size(711, 387);
            this.tabPageStudent.TabIndex = 0;
            this.tabPageStudent.Text = "Студенты";
            this.tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // rbGroups
            // 
            this.rbGroups.AutoSize = true;
            this.rbGroups.Location = new System.Drawing.Point(339, 63);
            this.rbGroups.Name = "rbGroups";
            this.rbGroups.Size = new System.Drawing.Size(114, 17);
            this.rbGroups.TabIndex = 6;
            this.rbGroups.TabStop = true;
            this.rbGroups.Text = "количество групп";
            this.rbGroups.UseVisualStyleBackColor = true;
            this.rbGroups.CheckedChanged += new System.EventHandler(this.rbGroups_CheckedChanged);
            // 
            // rbStud
            // 
            this.rbStud.AutoSize = true;
            this.rbStud.Location = new System.Drawing.Point(459, 63);
            this.rbStud.Name = "rbStud";
            this.rbStud.Size = new System.Drawing.Size(137, 17);
            this.rbStud.TabIndex = 5;
            this.rbStud.TabStop = true;
            this.rbStud.Text = "количество студентов";
            this.rbStud.UseVisualStyleBackColor = true;
            this.rbStud.CheckedChanged += new System.EventHandler(this.rbStud_CheckedChanged);
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(16, 63);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(307, 21);
            this.cbDirection.TabIndex = 4;
            this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
            // 
            // lblStudCount
            // 
            this.lblStudCount.AutoSize = true;
            this.lblStudCount.Location = new System.Drawing.Point(336, 21);
            this.lblStudCount.Name = "lblStudCount";
            this.lblStudCount.Size = new System.Drawing.Size(119, 13);
            this.lblStudCount.TabIndex = 3;
            this.lblStudCount.Text = "количество студентов";
            this.lblStudCount.Click += new System.EventHandler(this.lblStudCount_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(620, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgwStudents
            // 
            this.dgwStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.Location = new System.Drawing.Point(16, 90);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.Size = new System.Drawing.Size(679, 277);
            this.dgwStudents.TabIndex = 1;
            // 
            // cbGroup
            // 
            this.cbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(16, 21);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(307, 21);
            this.cbGroup.TabIndex = 0;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // tabPageTeacher
            // 
            this.tabPageTeacher.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeacher.Name = "tabPageTeacher";
            this.tabPageTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeacher.Size = new System.Drawing.Size(711, 387);
            this.tabPageTeacher.TabIndex = 1;
            this.tabPageTeacher.Text = "Преподаватели";
            this.tabPageTeacher.UseVisualStyleBackColor = true;
            // 
            // tabPGroups
            // 
            this.tabPGroups.Controls.Add(this.buttonAddGroup);
            this.tabPGroups.Controls.Add(this.dataGridView1);
            this.tabPGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPGroups.Name = "tabPGroups";
            this.tabPGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPGroups.Size = new System.Drawing.Size(711, 387);
            this.tabPGroups.TabIndex = 2;
            this.tabPGroups.Text = "Группы";
            this.tabPGroups.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(605, 6);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGroup.TabIndex = 1;
            this.buttonAddGroup.Text = "Добавить";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabGroups);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabGroups.ResumeLayout(false);
            this.tabPageStudent.ResumeLayout(false);
            this.tabPageStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.tabPGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGroups;
        private System.Windows.Forms.TabPage tabPageStudent;
        private System.Windows.Forms.TabPage tabPageTeacher;
        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStudCount;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.RadioButton rbGroups;
        private System.Windows.Forms.RadioButton rbStud;
        private System.Windows.Forms.TabPage tabPGroups;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

