using PetMagazine.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetMagazine.FormApp
{
    public partial class MainForm : Form
    {
        AppDbContext context = new AppDbContext();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm(context);
            form.ShowDialog();
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            PetForm form = new PetForm();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
