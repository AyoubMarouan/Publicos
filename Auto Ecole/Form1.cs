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
    public partial class Form1 : Form
    {
        static Form current_form = new Form();
        static Form main_form;

        public Form1()
        {
            InitializeComponent();
            main_form = this;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            changer_form( new Acceuie() );
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void changer_form(Form form) {
            current_form.Close();
            form.TopLevel = false;
            form.Parent = main_form;
            form.Location = new Point(233, 0);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            current_form = form;
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            changer_form(new client());
        }
    }
}
