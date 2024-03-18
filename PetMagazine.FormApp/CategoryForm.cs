using PetMagazine.Data;
using PetMagazine.Services;
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

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
