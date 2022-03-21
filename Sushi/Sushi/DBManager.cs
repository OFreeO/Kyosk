using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi
{
    public class DBManager
    {
        const string myDB = "Server = localhost;" +
            " Port = 3306;" +
            " Database = Sushi; " +
            "userid = root;" +
            " Pwd = 0729;";

        const string table = "Sushi";

        public static MySqlConnection Myconn = new MySqlConnection(myDB);

        public static List<Menu> menus = new List<Menu>();

        public static void ConnectDB()
        {
            try
            {
                Myconn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("실패");
                Console.WriteLine(e.ToString());
                Myconn.Close();
            }
        }

        public static void findfood(string c)
        {
            ConnectDB();

            MySqlDataAdapter mda = new MySqlDataAdapter();

            string sql = $"select * from sushi where category = '{c}'";

            mda.SelectCommand = new MySqlCommand();

            mda.SelectCommand.Connection = Myconn;

            mda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();

            mda.Fill(ds, table);

            menus.Clear();

            foreach(DataRow item in ds.Tables[0].Rows)
            {
                Menu menu = new Menu();
                menu.Name = item["menu"].ToString();
                menu.Category = item["category"].ToString();
                menu.Price = int.Parse(item["Price"].ToString());
                menu.Count = int.Parse(item["Count"].ToString());

                menus.Add(menu);
            }

            Myconn.Close();
        }
    }
}
