using Endangered_animals.Interface;
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
    public partial class DietP : Form
    {
        public DietP()
        {
            InitializeComponent();
        }

        private void LoadDietType()
        {
            var dietRepository = RepositoryFactory.Instance.CreateRepository<Alimentatie>();
            var diets = dietRepository.GetAll();
            listBox1.Items.Clear();
            foreach (var diet in diets)
            {
                listBox1.Items.Add(diet.tip_alimentatie);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void DietP_Load(object sender, EventArgs e)
        {
            LoadDietType();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedDietName = listBox1.SelectedItem.ToString();
                DisplayDiet(selectedDietName);
            }
        }

        private void DisplayDiet(string dietName)
        {
            var dietRepository = RepositoryFactory.Instance.CreateRepository<Alimentatie>();
            var diet = dietRepository.GetAll().FirstOrDefault(d => d.tip_alimentatie == dietName);

            if (diet != null)
            {
                tipAlimentatie.Text = diet.tip_alimentatie;
                descriere.Text = diet.descriere;
            }
        }
    }
}
