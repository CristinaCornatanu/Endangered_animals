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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Endangered_animals.Presentation
{
    public partial class Animals : Form
    {
        string fisierNume;
        public Animals()
        {
            InitializeComponent();
            listSpecAndAlim();
        }

        private void LoadDataGridView()
        {
            var animalRepository = RepositoryFactory.Instance.CreateRepository<Animal>();
            var animals = animalRepository.GetAll();
            dataGridView1.DataSource = animals;
            dataGridView1.Refresh();

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void Animals_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ShowDataInTextBoxes(dataGridView1.SelectedRows[0]);
            }
        }

        private void ShowDataInTextBoxes(DataGridViewRow selectedRow)
        {
            
            if (selectedRow != null)
            {
               

                int idAnimal;
                int.TryParse(selectedRow.Cells["Id"].Value.ToString(), out idAnimal);
                int idSpecie=(int)selectedRow.Cells["IdSpecie"].Value;
                var catRepository = RepositoryFactory.Instance.CreateRepository<Categorie_Specie>();
                var spec = catRepository.GetById(idSpecie);
                int idAl = (int)selectedRow.Cells["IdTipAlimentatie"].Value;
                var alimRepository = RepositoryFactory.Instance.CreateRepository<Alimentatie>();
                var alim = alimRepository.GetById(idAl);
                string type = (string)selectedRow.Cells["Type"].Value;
                string descriere = (string)selectedRow.Cells["Descriere"].Value;
                byte[] byteArray = (byte[])selectedRow.Cells["Imagine"].Value;


                
                id_animal.Text = idAnimal.ToString();
                comboBox1.SelectedText = spec.SpecieName;
                comboBox2.SelectedText = alim.tip_alimentatie;
                typeAnimal.Text = type.ToString();
                descriereAnimal.Text = descriere.ToString();
                Image image = ImageConverterHelper.ConvertByteArrayToImage(byteArray);
                pictureBox1.Image = image;
            }
        }
        public void listSpecAndAlim()
        {
            var catRepository = RepositoryFactory.Instance.CreateRepository<Categorie_Specie>();
            var cat = catRepository.GetAll();
            comboBox1.Items.Clear();
            foreach (var category in cat)
            {
                comboBox1.Items.Add(category.SpecieName);
            }
            var alimRepository = RepositoryFactory.Instance.CreateRepository<Alimentatie>();
            var alim = alimRepository.GetAll();
            comboBox2.Items.Clear();
            foreach (var alimentatie in alim)
            {
                comboBox2.Items.Add(alimentatie.tip_alimentatie);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog obPoza = new OpenFileDialog()
            {
                Filter = "JPEG|*.jpg",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (obPoza.ShowDialog() == DialogResult.OK)
                {
                    fisierNume = obPoza.FileName;
                    pictureBox1.Image = Image.FromFile(fisierNume);

                }
            }
        }
    }
}
