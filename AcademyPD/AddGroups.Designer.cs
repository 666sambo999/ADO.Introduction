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
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.btnGenerete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDirections
            // 
            this.cbDirections.FormattingEnabled = true;
            this.cbDirections.Location = new System.Drawing.Point(12, 35);
            this.cbDirections.Name = "cbDirections";
            this.cbDirections.Size = new System.Drawing.Size(271, 21);
            this.cbDirections.TabIndex = 0;
            this.cbDirections.Text = "Направления обучения";
            // 
            // cbForms
            // 
            this.cbForms.FormattingEnabled = true;
            this.cbForms.Location = new System.Drawing.Point(12, 74);
            this.cbForms.Name = "cbForms";
            this.cbForms.Size = new System.Drawing.Size(271, 21);
            this.cbForms.TabIndex = 1;
            this.cbForms.Text = "Форма обучения";
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(12, 113);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(271, 21);
            this.cbTime.TabIndex = 2;
            this.cbTime.Text = "Время обучения";
            // 
            // cbNameGroups
            // 
            this.cbNameGroups.FormattingEnabled = true;
            this.cbNameGroups.Location = new System.Drawing.Point(12, 158);
            this.cbNameGroups.Name = "cbNameGroups";
            this.cbNameGroups.Size = new System.Drawing.Size(271, 21);
            this.cbNameGroups.TabIndex = 3;
            this.cbNameGroups.Text = "название группы";
            // 
            // checkedList
            // 
            this.checkedList.CheckOnClick = true;
            this.checkedList.ColumnWidth = 50;
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Items.AddRange(new object[] {
            "пн",
            "вт",
            "ср",
            "чт",
            "пт",
            "сб",
            "вс"});
            this.checkedList.Location = new System.Drawing.Point(307, 55);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(53, 109);
            this.checkedList.TabIndex = 4;
            this.checkedList.SelectedIndexChanged += new System.EventHandler(this.checkedList_SelectedIndexChanged);
            // 
            // btnGenerete
            // 
            this.btnGenerete.Location = new System.Drawing.Point(285, 231);
            this.btnGenerete.Name = "btnGenerete";
            this.btnGenerete.Size = new System.Drawing.Size(75, 23);
            this.btnGenerete.TabIndex = 5;
            this.btnGenerete.Text = "Generete";
            this.btnGenerete.UseVisualStyleBackColor = true;
            this.btnGenerete.Click += new System.EventHandler(this.btnGenerete_Click);
            // 
            // AddGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 279);
            this.Controls.Add(this.btnGenerete);
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.cbNameGroups);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbForms);
            this.Controls.Add(this.cbDirections);
            this.Name = "AddGroups";
            this.Text = "AddGroups";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDirections;
        private System.Windows.Forms.ComboBox cbForms;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbNameGroups;
        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.Button btnGenerete;
    }
}