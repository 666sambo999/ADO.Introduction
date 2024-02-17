using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyPD
{
    public partial class AddStud : Form
    {
        public string FullName { get; set; }
        public DateTime BirtnDate { get; set; } 
        public string Group { get; set; }
        public ComboBox GroupCombo 
        {
            get { return comboBoxGroup; } 
        }
        
        public AddStud()
        {
            InitializeComponent();
            
        }

        private void lblGroup_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FullName = textBoxFullName.Text;
            BirtnDate = dateTimePicker1.Value;
            Group = comboBoxGroup.SelectedItem.ToString();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
