namespace PetMagazine.FormApp
{
    partial class PetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            breedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kindOfPetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            petViewModelBindingSource = new BindingSource(components);
            btnPrevious = new Button();
            btnNext = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, breedDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, ownerDataGridViewTextBoxColumn, kindOfPetDataGridViewTextBoxColumn, categoriesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = petViewModelBindingSource;
            dataGridView1.Location = new Point(469, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(926, 479);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // breedDataGridViewTextBoxColumn
            // 
            breedDataGridViewTextBoxColumn.DataPropertyName = "Breed";
            breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            breedDataGridViewTextBoxColumn.MinimumWidth = 6;
            breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            breedDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            ownerDataGridViewTextBoxColumn.MinimumWidth = 6;
            ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            ownerDataGridViewTextBoxColumn.Width = 125;
            // 
            // kindOfPetDataGridViewTextBoxColumn
            // 
            kindOfPetDataGridViewTextBoxColumn.DataPropertyName = "KindOfPet";
            kindOfPetDataGridViewTextBoxColumn.HeaderText = "KindOfPet";
            kindOfPetDataGridViewTextBoxColumn.MinimumWidth = 6;
            kindOfPetDataGridViewTextBoxColumn.Name = "kindOfPetDataGridViewTextBoxColumn";
            kindOfPetDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoriesDataGridViewTextBoxColumn
            // 
            categoriesDataGridViewTextBoxColumn.DataPropertyName = "Categories";
            categoriesDataGridViewTextBoxColumn.HeaderText = "Categories";
            categoriesDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoriesDataGridViewTextBoxColumn.Name = "categoriesDataGridViewTextBoxColumn";
            categoriesDataGridViewTextBoxColumn.Width = 125;
            // 
            // petViewModelBindingSource
            // 
            petViewModelBindingSource.DataSource = typeof(ViewModels.PetViewModel);
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(485, 525);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(211, 136);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(730, 525);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(199, 132);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(122, 53);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PetForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 690);
            Controls.Add(button1);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "PetForm";
            Text = "PetForm";
            Load += PetForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kindOfPetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriesDataGridViewTextBoxColumn;
        private BindingSource petViewModelBindingSource;
        private Button btnPrevious;
        private Button btnNext;
        private Button button1;
    }
}