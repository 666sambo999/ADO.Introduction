using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace AcademyPD
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        DataTable table;
        SqlDataReader reader;
        
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            //LoadTablesToComboBox();
            LoadGroupsToComboBox(cbGroup);
            SelectStudents();
            


        }
        //void LoadTablesToComboBox()
        //{
        //    string commandLine = @"SELECT table_name FROM information_schema.tables";
        //    SqlCommand cmd = new SqlCommand(commandLine, connection);
        //    connection.Open();
        //    reader = cmd.ExecuteReader();
        //    while(reader.Read()) { cbTables.Items.Add(reader[0]); }
        //    reader.Close();
        //    connection.Close();
        //}
        public void LoadGroupsToComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            string commandLine = @"SELECT group_name From Groups";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                comboBox.Items.Add(reader[0]);
            }

            reader.Close();
            connection.Close();
        }
       void SelectStudents(string group = "")
        {
            
            string commandLine =
                @"SELECT last_name, first_name, midle_name, date_of_birth,group_name
                FROM Students JOIN Groups ON Students.[group]=Groups.group_id";
            if (group.Length != 0) commandLine += $" WHERE [group_name] = '{group}'";            
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i =0; i<reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));   
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i<reader.FieldCount;i++)
                {
                    row[i] = reader[i];
                }
                // конвертируем дату рождения 
                row["date_of_birth"] = Convert.ToDateTime(reader["date_of_birth"]).ToString("yyyy.MM.dd");
                table.Rows.Add(row);
            }
            dgwStudents.DataSource = table;
            reader.Close();
            if (group.Length>0)
            {
                cmd.CommandText = $@" SELECT COUNT (stud_id) FROM 
                Students JOIN Groups ON Students.[group] = Groups.group_id 
                WHERE [group_name] = '{group}' GROUP BY group_name"; 
            }
            else
            {
                cmd.CommandText = $@" SELECT COUNT (stud_id) FROM 
                Students JOIN Groups ON Students.[group] = Groups.group_id"; 
            }
            lblStudCount.Text = $"Количество студентов: {Convert.ToInt32(cmd.ExecuteScalar()).ToString()}";
            connection.Close();

        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStudents(cbGroup.SelectedItem.ToString().Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStud add_Stud = new AddStud();
            LoadGroupsToComboBox(add_Stud.GroupCombo);
            DialogResult result = add_Stud.ShowDialog(this); // модальное окно которое блокирует родительсткое
            if (result == DialogResult.OK)
            {
                // нужен парметризованые запросы
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.Parameters.Add("@last_name", add_Stud.FullName.Split(' ')[0]);
                cmd.Parameters.Add("@first_name", add_Stud.FullName.Split(' ')[1]);
                if (add_Stud.FullName.Split(' ').Length==3)
                    cmd.Parameters.Add("@midle_name", add_Stud.FullName.Split(' ')[2]);
                cmd.Parameters.Add("@date_of_birth", add_Stud.BirtnDate.ToString("yyyy.MM.dd"));
                cmd.Parameters.Add("@group", add_Stud.Group);
                cmd.CommandText =
                   @"
                    IF NOT EXISTS (SELECT stud_id FROM Students WHERE last_name=@last_name AND first_name=@first_name AND midle_name=@midle_name) 
                    BEGIN
                    INSERT INTO Students (last_name, first_name, midle_name, date_of_birth, [group])
                   VALUES (@last_name, @first_name, @midle_name, @date_of_birth, (SELECT group_id
                   FROM Groups WHERE group_name = @group))
                    END";
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                cbGroup.SelectedItem = add_Stud.Group;
                SelectStudents();
            }
        }
    }
}
