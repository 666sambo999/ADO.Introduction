using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AcademyPD
{
    public partial class AddGroups : Form
    {
        private string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter; // вытягивает результаты запросов из базы, и сохраняет их в DataSet
        DataSet set;
        SqlCommandBuilder builder;
        public System.Windows.Forms.ComboBox CBDirections { get => cbDirections; }
        public System.Windows.Forms.ComboBox CbForm { get => cbForms; }
        public System.Windows.Forms.ComboBox CbTime { get => cbTime; }
        string[] week = new string[] { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };
        CheckBox[] cb_week;
        public AddGroups()
        {
            InitializeComponent();
            //((Form1)Parent).LoadDataToComboBox(cbDirections, "Directions", "direction_name", "выбирите направления обучения");
            //((Form1)Parent).LoadDataToComboBox(cbForms, "LearningForms", "form_name", "выбирите форму обучения");
            //((Form1)Parent).LoadDataToComboBox(cbTime, "LearningForms", "time_name", "выбирите время обучения");
            //CheckBox[] cb = new CheckBox[] { };
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            GetDataFromBase();
        }
        private void LoadComboBox(string sourceTable)
        {

        }

        void GetDataFromBase()
        {
            try
            {
                set = new DataSet();
                string cmd = $@" SELECT * FROM Directions";
                adapter = new SqlDataAdapter(cmd, connection);
                builder = new SqlCommandBuilder(adapter);
                adapter.Fill(set, "Directions");
                adapter.SelectCommand.CommandText = $@"SELECT * FROM LearningTime";
                builder.DataAdapter = adapter;
                adapter.Fill(set, "LearningTime");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(this, ex.Message);
            }
        }
        string GenereteGroupName()
        {
            string group_name = "";
            if (CbForm.SelectedItem.ToString() != "Годичные курсы") 
            {
                if (cbForms.SelectedItem.ToString() == "Полустационар") group_name += checkedList.SelectedItem.ToString(); 
                //if (cbDirections.SelectedItem.ToString() == "Разработка программного обеспечения")
                {
                    //DataRow[] rows = set.Tables["Directions"].Select("direction_name = 'Разработка программного обеспечения'");
                    //DataRow row  = rows[0];
                    //group_name += row["direction_code"];
                    group_name+=set.Tables["Directions"].Select($"direction_name='{cbDirections.SelectedItem.ToString()}'")[0]["direction_code"];
                    group_name+=set.Tables["LearningTime"].Select($"time_name='{cbTime.SelectedItem.ToString()}'")[0]["time_code"];
                }
            }
            group_name += "_";
            return group_name;
        }

        private void btnGenerete_Click(object sender, EventArgs e)
        {
            cbNameGroups.Text = GenereteGroupName();
        }

        private void checkedList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
