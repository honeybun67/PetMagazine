using System;
using PetMagazine.FormApp.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using PetMagazine.Data.Models;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetMagazine.Services;
using PetMagazine.Services.ENums;

namespace PetMagazine.FormApp
{
    public partial class PetForm : Form
    {
        private PetService service = new PetService();

        private PetService petService;
        private CategoryService categoryService = new CategoryService();
        private int currentPetId = -1;

        //Pagination variables
        private int currentPage = 1;
        private int animalsPerPage = 10;
        private int pageCount = 0;
        private int totalItems = 0;
        private bool ascSort = true;
        private PetSortBy sortBy = PetSortBy.Breed;

        public PetForm()
        {
            InitializeComponent();
        }

        private void PetForm_Load(object sender, EventArgs e)
        {
            LoadPets();
        }

        private void LoadPets()
        {
            dataGridView1.DataSource = petService
               .GetPets(currentPage, animalsPerPage, ascSort, sortBy)
               .Select(x => new PetViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   Breed = x.Breed,
                   Age = x.Age,
                   Owner = x.Owner,
                   Categories = string.Join(", ", x.Categories.Select(x => x.Category.Name)),
                   // ImageUrl = x.ImageUrl != null ? x.ImageUrl : GlobalConstants.DefaultImg,
               })
               .ToList();

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //lblPages.Text = $"{currentPage}/{pageCount}";
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
            LoadPets();
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
            LoadPets();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (service.GetPetsCount()<10)
            {
                for (int i = 0; i < 50; i++)
                {
                    service.Add(new Pet() 
                    { Name = $"Name {i}",
                      Breed = $"Breed {new Random().Next(1,11)}",
                      Age = new Random().Next(0,50),
                      Owner = $"Owner {new Random().Next(1,35)}",
                      KindOfPet = $"Kind {new Random().Next(1,20)}"
                    });
                }
            }
        }
    }
}
