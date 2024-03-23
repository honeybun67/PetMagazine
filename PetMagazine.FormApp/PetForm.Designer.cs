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
            ImgUrl = new DataGridViewTextBoxColumn();
            petViewModelBindingSource3 = new BindingSource(components);
            petViewModelBindingSource1 = new BindingSource(components);
            petViewModelBindingSource = new BindingSource(components);
            btnPrevious = new Button();
            btnNext = new Button();
            button1 = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbBreed = new ComboBox();
            label3 = new Label();
            txtAge = new TextBox();
            txtOwner = new TextBox();
            label4 = new Label();
            rbAdd = new RadioButton();
            rbDelete = new RadioButton();
            rbUpdate = new RadioButton();
            panel1 = new Panel();
            btnAction = new Button();
            label5 = new Label();
            cmbKind = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            lblCount = new Label();
            lblPages = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            cmbOrderBy = new ComboBox();
            cmdOrder = new ComboBox();
            petViewModelBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, breedDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, ownerDataGridViewTextBoxColumn, kindOfPetDataGridViewTextBoxColumn, categoriesDataGridViewTextBoxColumn, ImgUrl });
            dataGridView1.DataSource = petViewModelBindingSource3;
            dataGridView1.Location = new Point(767, 18);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(892, 411);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
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
            // ImgUrl
            // 
            ImgUrl.DataPropertyName = "Id";
            ImgUrl.HeaderText = "ImgUrl";
            ImgUrl.MinimumWidth = 6;
            ImgUrl.Name = "ImgUrl";
            ImgUrl.Width = 125;
            // 
            // petViewModelBindingSource3
            // 
            petViewModelBindingSource3.DataSource = typeof(ViewModels.PetViewModel);
            // 
            // petViewModelBindingSource1
            // 
            petViewModelBindingSource1.DataSource = typeof(ViewModels.PetViewModel);
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(794, 442);
            btnPrevious.Margin = new Padding(4, 3, 4, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(177, 83);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(979, 442);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(181, 83);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // button1
            // 
            button1.Location = new Point(2, 715);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(96, 48);
            button1.TabIndex = 3;
            button1.Text = "Seed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(535, 68);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 38);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 31);
            label2.TabIndex = 6;
            label2.Text = "Breed";
            // 
            // cmbBreed
            // 
            cmbBreed.FormattingEnabled = true;
            cmbBreed.Location = new Point(535, 125);
            cmbBreed.Margin = new Padding(4, 3, 4, 3);
            cmbBreed.Name = "cmbBreed";
            cmbBreed.Size = new Size(212, 39);
            cmbBreed.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 31);
            label3.TabIndex = 8;
            label3.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(535, 185);
            txtAge.Margin = new Padding(4, 3, 4, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(212, 38);
            txtAge.TabIndex = 9;
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(534, 240);
            txtOwner.Margin = new Padding(4, 3, 4, 3);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(213, 38);
            txtOwner.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 240);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 31);
            label4.TabIndex = 11;
            label4.Text = "Owner";
            // 
            // rbAdd
            // 
            rbAdd.AutoSize = true;
            rbAdd.Location = new Point(12, 18);
            rbAdd.Margin = new Padding(4, 3, 4, 3);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(78, 35);
            rbAdd.TabIndex = 12;
            rbAdd.TabStop = true;
            rbAdd.Text = "Add";
            rbAdd.UseVisualStyleBackColor = true;
            rbAdd.CheckedChanged += rbAdd_CheckedChanged_1;
            // 
            // rbDelete
            // 
            rbDelete.AutoSize = true;
            rbDelete.Location = new Point(259, 18);
            rbDelete.Margin = new Padding(4, 3, 4, 3);
            rbDelete.Name = "rbDelete";
            rbDelete.Size = new Size(101, 35);
            rbDelete.TabIndex = 13;
            rbDelete.TabStop = true;
            rbDelete.Text = "Delete";
            rbDelete.UseVisualStyleBackColor = true;
            rbDelete.CheckedChanged += rbDelete_CheckedChanged_1;
            // 
            // rbUpdate
            // 
            rbUpdate.AutoSize = true;
            rbUpdate.Location = new Point(125, 18);
            rbUpdate.Margin = new Padding(4, 3, 4, 3);
            rbUpdate.Name = "rbUpdate";
            rbUpdate.Size = new Size(111, 35);
            rbUpdate.TabIndex = 14;
            rbUpdate.TabStop = true;
            rbUpdate.Text = "Update";
            rbUpdate.UseVisualStyleBackColor = true;
            rbUpdate.CheckedChanged += rbUpdate_CheckedChanged_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbAdd);
            panel1.Controls.Add(rbDelete);
            panel1.Controls.Add(rbUpdate);
            panel1.Location = new Point(399, 354);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 78);
            panel1.TabIndex = 15;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(486, 449);
            btnAction.Margin = new Padding(4, 3, 4, 3);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(175, 100);
            btnAction.TabIndex = 16;
            btnAction.Text = "button2";
            btnAction.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 311);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 31);
            label5.TabIndex = 17;
            label5.Text = "Kind of pet";
            // 
            // cmbKind
            // 
            cmbKind.FormattingEnabled = true;
            cmbKind.Location = new Point(535, 308);
            cmbKind.Margin = new Padding(4, 3, 4, 3);
            cmbKind.Name = "cmbKind";
            cmbKind.Size = new Size(213, 39);
            cmbKind.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1166, 468);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(123, 31);
            label6.TabIndex = 19;
            label6.Text = "Pets Count";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1166, 510);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 31);
            label7.TabIndex = 20;
            label7.Text = "Pages";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(1308, 468);
            lblCount.Margin = new Padding(4, 0, 4, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(76, 31);
            lblCount.TabIndex = 21;
            lblCount.Text = "label8";
            lblCount.Click += lblCount_Click;
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Location = new Point(1308, 510);
            lblPages.Margin = new Padding(4, 0, 4, 0);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(76, 31);
            lblPages.TabIndex = 22;
            lblPages.Text = "label9";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2, 34);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 465);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(995, 581);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(97, 31);
            label8.TabIndex = 24;
            label8.Text = "OrderBy";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(995, 654);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(73, 31);
            label9.TabIndex = 25;
            label9.Text = "Order";
            // 
            // cmbOrderBy
            // 
            cmbOrderBy.FormattingEnabled = true;
            cmbOrderBy.Location = new Point(1139, 581);
            cmbOrderBy.Margin = new Padding(4, 3, 4, 3);
            cmbOrderBy.Name = "cmbOrderBy";
            cmbOrderBy.Size = new Size(187, 39);
            cmbOrderBy.TabIndex = 26;
            cmbOrderBy.SelectedIndexChanged += cmbOrderBy_SelectedIndexChanged_1;
            // 
            // cmdOrder
            // 
            cmdOrder.FormattingEnabled = true;
            cmdOrder.Location = new Point(1139, 651);
            cmdOrder.Margin = new Padding(4, 3, 4, 3);
            cmdOrder.Name = "cmdOrder";
            cmdOrder.Size = new Size(187, 39);
            cmdOrder.TabIndex = 27;
            cmdOrder.SelectedIndexChanged += cmdOrder_SelectedIndexChanged;
            // 
            // petViewModelBindingSource2
            // 
            petViewModelBindingSource2.DataSource = typeof(ViewModels.PetViewModel);
            // 
            // PetForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 764);
            Controls.Add(cmdOrder);
            Controls.Add(cmbOrderBy);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(lblPages);
            Controls.Add(lblCount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbKind);
            Controls.Add(label5);
            Controls.Add(btnAction);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(txtOwner);
            Controls.Add(txtAge);
            Controls.Add(label3);
            Controls.Add(cmbBreed);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(button1);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 4, 5, 4);
            Name = "PetForm";
            Text = "PetForm";
            Load += PetForm_Load;
            DoubleClick += PetForm_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private ComboBox cmbBreed;
        private Label label3;
        private TextBox txtAge;
        private TextBox txtOwner;
        private Label label4;
        private RadioButton rbAdd;
        private RadioButton rbDelete;
        private RadioButton rbUpdate;
        private Panel panel1;
        private Button btnAction;
        private Label label5;
        private ComboBox cmbKind;
        private Label label6;
        private Label label7;
        private Label lblCount;
        private Label lblPages;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private ComboBox cmbOrderBy;
        private ComboBox cmdOrder;
        private BindingSource petViewModelBindingSource1;
        private BindingSource petViewModelBindingSource2;
        private DataGridViewTextBoxColumn ImgUrl;
        private BindingSource petViewModelBindingSource3;
    }
}