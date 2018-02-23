using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Ecole
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToResizeColumns = false;

            dataGridView2.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dataGridView2.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            for (int i = 0; i < 30; i++)
            {
                dataGridView1.Rows.Add("ayoub", "marouan");
                dataGridView2.Rows.Add("300 DH", "12/10/2017","Amine");
            }
                
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void client_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {
            Form1.changer_form( new AjouterClient() );
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
