namespace PetMagazine.FormApp
{
    using PetMagazine.Data.Models;
    using PetMagazine.Services;
    using PetMagazine.FormApp.ViewModels;
    using System.Data;
    using PetMagazine.Services.ENums;
    using PetMagazine.Common;
    using PetMagazine.Data;
    using System.Windows.Forms;

    public partial class PetForm : Form
    {
        private PetService petService;
        private CategoryService categoryService;
        private int currentPetId = -1;

        //Pagination variables
        private int currentPage = 1;
        private int animalsPerPage = 10;
        private int pageCount = 0;
        private int totalAnimals = 0;
        private bool ascSort = true;
        private PetSortBy sortBy = PetSortBy.Breed;

        public PetForm(AppDbContext context)
        {
            InitializeComponent();
            categoryService = new CategoryService(context);
            petService = new PetService(context);
        }

        private void PetsForm_Load(object sender, EventArgs e)
        {
            UpdatePagination();
            LoadPets();
            pictureBox1.Load(GlobalConstants.DefaultImg);

            cmbOrderBy.Items.AddRange(System.Enum.GetNames<PetSortBy>());
            cmdOrder.SelectedIndex = 0;
            cmbOrderBy.SelectedIndex = 0;
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
                    KindOfPet = x.KindOfPet,
                    Categories = string.Join(", ", x.Categories.Select(x => x.Category.Name)),
                    ImageUrl = x.ImgUrl != null ? x.ImgUrl : GlobalConstants.DefaultImg,
                })
                .ToList();

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblPages.Text = $"{currentPage}/{pageCount}";
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
            if (petService.GetPetsCount() < 40)
            {
                List<int> categories = categoryService.GetCategoriesId();

                for (int i = 1; i < 60; i++)
                {
                    Pet pet = new Pet()
                    {
                        Name = $"Name {i}",
                        Breed = $"Breed {new Random().Next(1, 11)}",
                        Age = new Random().Next(0, 50),
                        Owner = $"Owner {new Random().Next(1, 35)}",
                        KindOfPet = $"Kind {new Random().Next(1, 20)}"

                    };
                    pet.Categories.Add(new PetCategory() { CategoryId = categories[new Random().Next(0, categories.Count)] });
                    petService.Add(pet);
                }
            }
        }

        private void UpdatePagination()
        {
            totalAnimals = petService.GetPetsCount();
            pageCount = (int)Math.Ceiling((double)totalAnimals / animalsPerPage);
            lblCount.Text = totalAnimals.ToString();
            lblPages.Text = $"{currentPage}/{pageCount}";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var item = dataGridView1.SelectedRows[0];
            currentPetId = int.Parse(item.Cells[0].Value.ToString());
            txtName.Text = item.Cells[1].Value.ToString();
            cmbBreed.Text = item.Cells[2].Value.ToString();
            txtAge.Text = item.Cells[3].Value.ToString();
            txtOwner.Text = item.Cells[4].Value.ToString();
            cmbKind.Text = item.Cells[5].Value.ToString();
            rbUpdate.Checked = true;
            try
            {
                pictureBox1.Load(item.Cells[6].Value.ToString());
            }
            catch (Exception)
            {
                pictureBox1.Load(GlobalConstants.DefaultImg);
            }
            rbUpdate.Checked = true;
        }



        private void rbAdd_CheckedChanged_1(object sender, EventArgs e)
        {
            btnAction.Text = "Add";
            ClearComponents();
            cmbBreed.Items.AddRange(petService.GetBreedsList());
        }

        private void rbUpdate_CheckedChanged_1(object sender, EventArgs e)
        {
            btnAction.Text = "Update";
        }

        private void rbDelete_CheckedChanged_1(object sender, EventArgs e)
        {
            btnAction.Text = "Delete";
        }


        public void ClearComponents()
        {
            txtName.Text = string.Empty;
            cmbBreed.Items.Clear();
            txtAge.Text = string.Empty;
            txtOwner.Text = string.Empty;
            cmbKind.Items.Clear();
        }


        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAdd.Checked)
                {
                    Pet pet = new Pet()
                    {
                        Name = txtName.Text,
                        Breed = cmbBreed.Text,
                        Age = int.Parse(txtAge.Text),
                        Owner = txtOwner.Text,
                        KindOfPet = cmbKind.Text
                    };
                    int id = petService.Add(pet);
                    MessageBox.Show(string.Format(OutputMessages.AddPet, id));
                }
                else if (rbDelete.Checked)
                {
                    if (currentPetId != -1)
                    {
                        int id = petService.DeletePet(currentPetId);
                        MessageBox.Show(string.Format(OutputMessages.DeletePet, id));
                    }
                    else
                    {
                        MessageBox.Show(OutputMessages.PetNotSelected);
                    }
                }
                else if (rbUpdate.Checked)
                {
                    if (currentPetId != -1)
                    {
                        Pet pet = petService.GetPetById(currentPetId);
                        pet.Name = txtName.Text;
                        pet.Breed = cmbBreed.Text;
                        pet.Age = int.Parse(txtAge.Text);
                        pet.Owner = txtOwner.Text;
                        int id = petService.EditPet(pet);
                        MessageBox.Show(string.Format(OutputMessages.EditPet, id));
                    }
                    else
                    {
                        MessageBox.Show(OutputMessages.PetNotSelected);
                    }

                }
                currentPetId = -1;
                ClearComponents();
                UpdatePagination();
                LoadPets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbOrderBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sortBy = Enum.Parse<PetSortBy>(cmbOrderBy.Text);
            LoadPets();
        }

        private void cmdOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = cmdOrder.Text == "ASC" ? ascSort = true : ascSort = false;
            LoadPets();
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            var item = dataGridView1.SelectedRows[0];
            currentPetId = int.Parse(item.Cells[0].Value.ToString());
            txtName.Text = item.Cells[1].Value.ToString();
            cmbBreed.Text = item.Cells[2].Value.ToString();
            txtAge.Text = item.Cells[3].Value.ToString();
            txtOwner.Text = item.Cells[4].Value.ToString();
            cmbKind.Text = item.Cells[5].Value.ToString();
            rbUpdate.Checked = true;

            try
            {
                pictureBox1.Load(item.Cells[7].Value.ToString());
            }
            catch (Exception)
            {
                pictureBox1.Load(GlobalConstants.DefaultImg);
            }
            rbUpdate.Checked = true;
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            PetCategoriesForm form = new PetCategoriesForm(petService, categoryService, currentPetId);
            form.ShowDialog();
        }
    }
}
