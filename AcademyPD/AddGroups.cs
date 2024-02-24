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
    public partial class AddGroups : Form
    {
        public AddGroups()
        {
            InitializeComponent();
            ((Form1)Parent).LoadDataToComboBox(cbDirections, "Directions", "direction_name", "выбирите направления обучения");
            ((Form1)Parent).LoadDataToComboBox(cbForms, "LearningForms", "form_name", "выбирите форму обучения");
            ((Form1)Parent).LoadDataToComboBox(cbTime, "LearningForms", "time_name", "выбирите время обучения");
        }
        private void LoadComboBox(string sourceTable)
        {

        }


        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
