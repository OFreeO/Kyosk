using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi
{
    public partial class Main : Form
    {
            DBManager dm = new DBManager();

        public Main()
        {
            InitializeComponent();
        }

        private void WriteLog(string contents)
        {
            string content = contents;
            DBManager.PrintLog(content);
            listBox1.Items.Insert(0, content);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_Label.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 hh:mm:ss.fff");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string c = "스시";

            DBManager.findfood(c);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBManager.menus;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            string c = "튀김/사이드";

            DBManager.findfood(c);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBManager.menus;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string c = "음료";

            DBManager.findfood(c);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBManager.menus;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string c = "디저트";

            DBManager.findfood(c);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBManager.menus;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int i = dataGridView1.CurrentRow.Index;
            string name = dataGridView1.Rows[i].Cells[0].Value.ToString();

            string content = $"{name} 추가됨";

            WriteLog(content);

        }
    }
}
