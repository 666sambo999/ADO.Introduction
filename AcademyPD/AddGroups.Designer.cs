namespace AcademyPD
{
    partial class AddGroups
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
            this.cbDirections = new System.Windows.Forms.ComboBox();
            this.cbForms = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbNameGroups = new System.Windows.Forms.ComboBox();
            this.gbDateOf = new System.Windows.Forms.GroupBox();
            this.cbSun = new System.Windows.Forms.CheckBox();
            this.cbSat = new System.Windows.Forms.CheckBox();
            this.cbFrid = new System.Windows.Forms.CheckBox();
            this.cbThur = new System.Windows.Forms.CheckBox();
            this.cbWedn = new System.Windows.Forms.CheckBox();
            this.cbTues = new System.Windows.Forms.CheckBox();
            this.cbMon = new System.Windows.Forms.CheckBox();
            this.gbDateOf.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDirections
            // 
            this.cbDirections.FormattingEnabled = true;
            this.cbDirections.Location = new System.Drawing.Point(46, 33);
            this.cbDirections.Name = "cbDirections";
            this.cbDirections.Size = new System.Drawing.Size(314, 21);
            this.cbDirections.TabIndex = 0;
            this.cbDirections.Text = "Направления обучения";
            // 
            // cbForms
            // 
            this.cbForms.FormattingEnabled = true;
            this.cbForms.Location = new System.Drawing.Point(46, 71);
            this.cbForms.Name = "cbForms";
            this.cbForms.Size = new System.Drawing.Size(314, 21);
            this.cbForms.TabIndex = 1;
            this.cbForms.Text = "Форма обучения";
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(46, 116);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(314, 21);
            this.cbTime.TabIndex = 2;
            this.cbTime.Text = "Время обучения";
            // 
            // cbNameGroups
            // 
            this.cbNameGroups.FormattingEnabled = true;
            this.cbNameGroups.Location = new System.Drawing.Point(46, 202);
            this.cbNameGroups.Name = "cbNameGroups";
            this.cbNameGroups.Size = new System.Drawing.Size(314, 21);
            this.cbNameGroups.TabIndex = 3;
            this.cbNameGroups.Text = "название группы";
            // 
            // gbDateOf
            // 
            this.gbDateOf.Controls.Add(this.cbSun);
            this.gbDateOf.Controls.Add(this.cbSat);
            this.gbDateOf.Controls.Add(this.cbFrid);
            this.gbDateOf.Controls.Add(this.cbThur);
            this.gbDateOf.Controls.Add(this.cbWedn);
            this.gbDateOf.Controls.Add(this.cbTues);
            this.gbDateOf.Controls.Add(this.cbMon);
            this.gbDateOf.Location = new System.Drawing.Point(46, 144);
            this.gbDateOf.Name = "gbDateOf";
            this.gbDateOf.Size = new System.Drawing.Size(314, 52);
            this.gbDateOf.TabIndex = 4;
            this.gbDateOf.TabStop = false;
            this.gbDateOf.Text = "Дни обучения";
            // 
            // cbSun
            // 
            this.cbSun.AutoSize = true;
            this.cbSun.Location = new System.Drawing.Point(270, 19);
            this.cbSun.Name = "cbSun";
            this.cbSun.Size = new System.Drawing.Size(38, 17);
            this.cbSun.TabIndex = 6;
            this.cbSun.Text = "вс";
            this.cbSun.UseVisualStyleBackColor = true;
            this.cbSun.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // cbSat
            // 
            this.cbSat.AutoSize = true;
            this.cbSat.Location = new System.Drawing.Point(222, 19);
            this.cbSat.Name = "cbSat";
            this.cbSat.Size = new System.Drawing.Size(38, 17);
            this.cbSat.TabIndex = 5;
            this.cbSat.Text = "сб";
            this.cbSat.UseVisualStyleBackColor = true;
            // 
            // cbFrid
            // 
            this.cbFrid.AutoSize = true;
            this.cbFrid.Location = new System.Drawing.Point(179, 19);
            this.cbFrid.Name = "cbFrid";
            this.cbFrid.Size = new System.Drawing.Size(37, 17);
            this.cbFrid.TabIndex = 4;
            this.cbFrid.Text = "пт";
            this.cbFrid.UseVisualStyleBackColor = true;
            // 
            // cbThur
            // 
            this.cbThur.AutoSize = true;
            this.cbThur.Location = new System.Drawing.Point(137, 19);
            this.cbThur.Name = "cbThur";
            this.cbThur.Size = new System.Drawing.Size(36, 17);
            this.cbThur.TabIndex = 3;
            this.cbThur.Text = "чт";
            this.cbThur.UseVisualStyleBackColor = true;
            // 
            // cbWedn
            // 
            this.cbWedn.AutoSize = true;
            this.cbWedn.Location = new System.Drawing.Point(93, 19);
            this.cbWedn.Name = "cbWedn";
            this.cbWedn.Size = new System.Drawing.Size(38, 17);
            this.cbWedn.TabIndex = 2;
            this.cbWedn.Text = "ср";
            this.cbWedn.UseVisualStyleBackColor = true;
            // 
            // cbTues
            // 
            this.cbTues.AutoSize = true;
            this.cbTues.Location = new System.Drawing.Point(50, 19);
            this.cbTues.Name = "cbTues";
            this.cbTues.Size = new System.Drawing.Size(37, 17);
            this.cbTues.TabIndex = 1;
            this.cbTues.Text = "вт";
            this.cbTues.UseVisualStyleBackColor = true;
            // 
            // cbMon
            // 
            this.cbMon.AutoSize = true;
            this.cbMon.Location = new System.Drawing.Point(6, 19);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(38, 17);
            this.cbMon.TabIndex = 0;
            this.cbMon.Text = "пн";
            this.cbMon.UseVisualStyleBackColor = true;
            // 
            // AddGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 301);
            this.Controls.Add(this.gbDateOf);
            this.Controls.Add(this.cbNameGroups);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbForms);
            this.Controls.Add(this.cbDirections);
            this.Name = "AddGroups";
            this.Text = "AddGroups";
            this.gbDateOf.ResumeLayout(false);
            this.gbDateOf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDirections;
        private System.Windows.Forms.ComboBox cbForms;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbNameGroups;
        private System.Windows.Forms.GroupBox gbDateOf;
        private System.Windows.Forms.CheckBox cbSun;
        private System.Windows.Forms.CheckBox cbSat;
        private System.Windows.Forms.CheckBox cbFrid;
        private System.Windows.Forms.CheckBox cbThur;
        private System.Windows.Forms.CheckBox cbWedn;
        private System.Windows.Forms.CheckBox cbTues;
        private System.Windows.Forms.CheckBox cbMon;
    }
}