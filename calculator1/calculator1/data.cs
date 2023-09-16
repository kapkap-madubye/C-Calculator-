using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    class data
    {
        public static string connectionstring = "server=localhost;uid=root;password='';database=calculator";
        MySqlConnection connection = new MySqlConnection(connectionstring);
        MySqlCommand command;

        void OpenClose()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {
                connection.Close();
            }
        }

        public void InsertData(int num1, string option,int num2,int result)
        {
            string sql = $"insert into users values(default,'{num1}','{option}','{num2}','{result}')";
            OpenClose();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();

            OpenClose();
        }
        public DataTable Select()
        {
            OpenClose();
            DataTable table = new DataTable();
            string sql = "select * from users";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
            dataAdapter.Fill(table);
            return table;
        }

    }
}
