using Endangered_animals.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endangered_animals
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DietP diet = new DietP();
            this.Hide();
            diet.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Species species = new Species();
            species.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animals an = new Animals();
            an.Show();
            this.Hide();
        }
    }
}
