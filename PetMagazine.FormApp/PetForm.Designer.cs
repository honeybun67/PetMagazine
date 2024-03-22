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
            petViewModelBindingSource1 = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dataGridView1.DataSource = petViewModelBindingSource1;
            dataGridView1.Location = new Point(771, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(634, 383);
            dataGridView1.TabIndex = 0;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(842, 414);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(150, 75);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1009, 414);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(153, 75);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // button1
            // 
            button1.Location = new Point(2, 646);
            button1.Name = "button1";
            button1.Size = new Size(81, 43);
            button1.TabIndex = 3;
            button1.Text = "Seed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(546, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 34);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 61);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 118);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 6;
            label2.Text = "Breed";
            // 
            // cmbBreed
            // 
            cmbBreed.FormattingEnabled = true;
            cmbBreed.Location = new Point(546, 110);
            cmbBreed.Name = "cmbBreed";
            cmbBreed.Size = new Size(180, 36);
            cmbBreed.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 173);
            label3.Name = "label3";
            label3.Size = new Size(47, 28);
            label3.TabIndex = 8;
            label3.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(546, 167);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(180, 34);
            txtAge.TabIndex = 9;
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(545, 217);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(181, 34);
            txtOwner.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 220);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 11;
            label4.Text = "Owner";
            label4.Click += label4_Click;
            // 
            // rbAdd
            // 
            rbAdd.AutoSize = true;
            rbAdd.Location = new Point(10, 16);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(70, 32);
            rbAdd.TabIndex = 12;
            rbAdd.TabStop = true;
            rbAdd.Text = "Add";
            rbAdd.UseVisualStyleBackColor = true;
            rbAdd.CheckedChanged += rbAdd_CheckedChanged_1;
            // 
            // rbDelete
            // 
            rbDelete.AutoSize = true;
            rbDelete.Location = new Point(269, 16);
            rbDelete.Name = "rbDelete";
            rbDelete.Size = new Size(89, 32);
            rbDelete.TabIndex = 13;
            rbDelete.TabStop = true;
            rbDelete.Text = "Delete";
            rbDelete.UseVisualStyleBackColor = true;
            rbDelete.CheckedChanged += rbDelete_CheckedChanged_1;
            // 
            // rbUpdate
            // 
            rbUpdate.AutoSize = true;
            rbUpdate.Location = new Point(106, 16);
            rbUpdate.Name = "rbUpdate";
            rbUpdate.Size = new Size(98, 32);
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
            panel1.Location = new Point(403, 337);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 70);
            panel1.TabIndex = 15;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(486, 414);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(148, 90);
            btnAction.TabIndex = 16;
            btnAction.Text = "button2";
            btnAction.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 286);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 17;
            label5.Text = "Kind of pet";
            // 
            // cmbKind
            // 
            cmbKind.FormattingEnabled = true;
            cmbKind.Location = new Point(545, 278);
            cmbKind.Name = "cmbKind";
            cmbKind.Size = new Size(181, 36);
            cmbKind.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1177, 437);
            label6.Name = "label6";
            label6.Size = new Size(105, 28);
            label6.TabIndex = 19;
            label6.Text = "Pets Count";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1177, 479);
            label7.Name = "label7";
            label7.Size = new Size(62, 28);
            label7.TabIndex = 20;
            label7.Text = "Pages";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(1313, 432);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(65, 28);
            lblCount.TabIndex = 21;
            lblCount.Text = "label8";
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Location = new Point(1313, 479);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(65, 28);
            lblPages.TabIndex = 22;
            lblPages.Text = "label9";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 449);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(842, 525);
            label8.Name = "label8";
            label8.Size = new Size(84, 28);
            label8.TabIndex = 24;
            label8.Text = "OrderBy";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(842, 591);
            label9.Name = "label9";
            label9.Size = new Size(63, 28);
            label9.TabIndex = 25;
            label9.Text = "Order";
            // 
            // cmbOrderBy
            // 
            cmbOrderBy.FormattingEnabled = true;
            cmbOrderBy.Location = new Point(964, 525);
            cmbOrderBy.Name = "cmbOrderBy";
            cmbOrderBy.Size = new Size(159, 36);
            cmbOrderBy.TabIndex = 26;
            cmbOrderBy.SelectedIndexChanged += cmbOrderBy_SelectedIndexChanged_1;
            // 
            // cmdOrder
            // 
            cmdOrder.FormattingEnabled = true;
            cmdOrder.Location = new Point(964, 588);
            cmdOrder.Name = "cmdOrder";
            cmdOrder.Size = new Size(159, 36);
            cmdOrder.TabIndex = 27;
            cmdOrder.SelectedIndexChanged += cmdOrder_SelectedIndexChanged;
            // 
            // petViewModelBindingSource1
            // 
            petViewModelBindingSource1.DataSource = typeof(ViewModels.PetViewModel);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Breed";
            dataGridViewTextBoxColumn3.HeaderText = "Breed";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Age";
            dataGridViewTextBoxColumn4.HeaderText = "Age";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Owner";
            dataGridViewTextBoxColumn5.HeaderText = "Owner";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "KindOfPet";
            dataGridViewTextBoxColumn6.HeaderText = "KindOfPet";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Categories";
            dataGridViewTextBoxColumn7.HeaderText = "Categories";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // PetForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 690);
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
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "PetForm";
            Text = "PetForm";
            Load += PetForm_Load;
            DoubleClick += PetForm_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)petViewModelBindingSource1).EndInit();
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private BindingSource petViewModelBindingSource1;
    }
}