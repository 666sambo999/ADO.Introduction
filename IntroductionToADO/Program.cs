using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace IntroductionToADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryPD212;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connection_string); // ������� ���������� � �������� ��� �������� ��� �� �������
            connection.Open(); // ��������� ����������, ��������� ��� �� ��������������, � �� ���������
            // ������� 
            //string insert_author = @"INSERT INTO Authors (first_name,last_name) VALUES ('Leo','Tolstoy')"; // ������ � SQL
            string insert_string = @"INSERT INTO Books (author,title, price, pages) VALUES ('5','War and Peace',240, 2000)"; // ������ � SQL
            //����� ��������� ������ ����� �������
            //SqlCommand cmd = new SqlCommand(insert_author, connection);
            SqlCommand cmd = new SqlCommand(insert_string, connection);
            //cmd.ExecuteNonQuery();  // - ���� ����� ��� ������ Insert, Upgate, Delete

            // ������� 
            //string select_string = @"Select * From Authors";
            string select_string = @"Select * From Books";
            cmd.CommandText = select_string;
            
            SqlDataReader rdl =  cmd.ExecuteReader();
            while (rdl.Read())
            {
                Console.WriteLine($"{rdl[0]} {rdl[1]} {rdl[2]}");
            }
            connection.Close(); // ���������� ����� ��������� 
        }
    }
}
