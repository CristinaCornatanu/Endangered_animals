using Endangered_animals.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endangered_animals.Presentation
{
    public partial class Species : Form
    {
        public Species()
        {
            InitializeComponent();
        }
        private void LoadCategory()
        {
            var catRepository = RepositoryFactory.Instance.CreateRepository<Categorie_Specie>();
            var cat = catRepository.GetAll();
            listView1.Items.Clear();
            foreach (var category in cat)
            {
                listView1.Items.Add(category.SpecieName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void Species_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
    }
}
