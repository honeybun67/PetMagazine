using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetMagazine.Data.Models;
using PetMagazine.Services;

namespace PetMagazine.FormApp
{
    public partial class PetCategoriesForm : Form
    {

        PetService petService;
        CategoryService categoryService;
        Pet currentPet;


        public PetCategoriesForm(PetService petService, CategoryService categoryService, int petId)
        {
            InitializeComponent();
            this.petService = petService;
            this.categoryService = categoryService;
            currentPet = petService.GetPetById(petId);
        }

        private void PetCategoriesForm_Load(object sender, EventArgs e)
        {
            lblName.Text = currentPet.Name;
            lblBreed.Text = currentPet.Breed;
            checkedListBox1.Items.AddRange(categoryService.GetAllCategories());
            LoadPetCategories();
        }

        private void LoadPetCategories()
        {
            List<string> petCategories = currentPet.Categories.Select(x => x.Category.Name).ToList();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (petCategories.Any(x => x == checkedListBox1.Items[i].ToString()))
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            currentPet.Categories.Clear();
            petService.EditPetCategories(currentPet);
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string categoryName = checkedListBox1.CheckedItems[i].ToString();
                currentPet.Categories.Add(new PetCategory() { Category = categoryService.GetCategoryByName(categoryName) });
            }
            petService.EditPetCategories(currentPet);


            MessageBox.Show("Pet is updated!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
