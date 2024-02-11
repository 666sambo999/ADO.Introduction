using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Library
{
    class Program
    {
        SqlConnection connection;
        SqlCommand cmd;
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Console.WriteLine(connectionString);
            
            Library library = new Library(connectionString);
            
            library.InsertAuthor("Alighieri", "Dante");
            library.SelectAuthors();
            //library.InsertBoors("Alighieri", "Dante", "The Divine comedy", "200", "300");
        }

    }
}
