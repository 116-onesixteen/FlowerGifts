using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class Items_restock : Form
    {
        public Items_restock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Dashboard c = new Dashboard();
            c.Show();





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Items d = new Items();
            d.Show();





        }
    }
}
