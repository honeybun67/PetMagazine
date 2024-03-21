namespace PetMagazine.FormApp
{
    using PetMagazine.Common;
    using PetMagazine.Data;
    using PetMagazine.Data.Models;
    using PetMagazine.Services;
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
    public partial class CategoryForm : Form
    {
        CategoryService service;

        //Pagination variables
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int pageCount = 0;
        private int totalItems = 0;
        private bool ascSort = true;


        public CategoryForm(AppDbContext context)
        {
            InitializeComponent();
            service = new CategoryService(context);
        }
        private void LoadCategories()
        {
            listBox1.Items.Clear();
            string[] ganres = service.GetCategories(currentPage, itemsPerPage, ascSort)
                .Select(x => $"{x.Id} - {x.Name}")
                .ToArray();
            listBox1.Items.AddRange(ganres);
            lblPageInfo.Text = $"{currentPage}/{pageCount}";
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            btnAcion.Text = rbAdd.Text;
            rbAdd.Checked = true;
            rbDelete.Enabled = false;
            rbUpdate.Enabled = false;

            //Default asc order
            rbAsc.Checked = true;

            comboBox1.SelectedText = itemsPerPage.ToString();

            UpdatePagination();

            LoadCategories();
        }
        private void UpdatePagination()
        {
            totalItems = service.GetCategoriesCount();
            pageCount = (int)Math.Ceiling((double)totalItems / itemsPerPage);

            lblCount.Text = totalItems.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if ((currentPage - 1) > 0)
            {
                currentPage--;
            }
            else
            {
                currentPage = pageCount;
            }
            LoadCategories();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage + 1 <= pageCount)
            {
                currentPage++;
            }
            else
            {
                currentPage = 1;
            }
            LoadCategories();
        }

        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            ascSort = true;
            LoadCategories();
        }
        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            ascSort = false;
            LoadCategories();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsPerPage = int.Parse(comboBox1.Text);
            currentPage = 1;
            UpdatePagination();
            LoadCategories();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] info = listBox1.Text.Split(" - ");
            txtId.Text = info[0];
            txtName.Text = info[1];
            txtAge.Text = info[2];
            txtMedal.Text = info[3];
            txtAchiev.Text = info[4];
            rbUpdate.Enabled = true;
            rbDelete.Enabled = true;

            RadioCheckedFalse();

            btnAcion.Enabled = false;
        }
        private void RadioCheckedFalse()
        {
            //Remove radio selection
            rbAdd.Checked = false;
            rbDelete.Checked = false;
            rbUpdate.Checked = false;
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {

            btnAcion.Enabled = true;
            btnAcion.Text = rbAdd.Text;
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtMedal.Text = string.Empty;
            txtAchiev.Text = string.Empty;
            rbUpdate.Enabled = false;
            rbDelete.Enabled = false;
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnAcion.Enabled = true;
            btnAcion.Text = rbUpdate.Text;
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            btnAcion.Enabled = true;
            btnAcion.Text = rbDelete.Text;
        }

        private void btnAcion_Click(object sender, EventArgs e)
        {
            try
            {
                // Add category
                if (rbAdd.Checked)
                {
                    Category category = new Category() { Name = txtName.Text, AgeGroup = txtAge.Text,Medal = txtMedal.Text,Achievements = txtAchiev.Text };
                    int id = service.Add(category);
                    MessageBox.Show(string.Format(OutputMessages.AddCategory, id, category.Name));
                }
                // Edit category
                else if (rbUpdate.Checked)
                {
                    int id = int.Parse(txtId.Text);
                    string name = txtName.Text;
                    service.EditCategory(id, name);
                    MessageBox.Show(string.Format(OutputMessages.EditCategory, id));
                }
                // Delete category
                else if (rbDelete.Checked)
                {
                    int id = int.Parse(txtId.Text);
                    service.DeleteCategory(id);
                    MessageBox.Show(string.Format(OutputMessages.DeleteCategory, id));
                }
                txtId.Text = string.Empty;
                txtName.Text = string.Empty;
                RadioCheckedFalse();
                UpdatePagination();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

