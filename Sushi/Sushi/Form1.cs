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
    public partial class Form1 : Form
    {
            DBManager dm = new DBManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void WriteLog(string contents)
        {
            string content = contents;
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
            listBox1.add

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
    }
}
