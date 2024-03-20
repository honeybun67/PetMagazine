namespace PetMagazine.FormApp
{
    partial class CategoryForm
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
            listBox1 = new ListBox();
            panel1 = new Panel();
            rbDesc = new RadioButton();
            rbAsc = new RadioButton();
            label1 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            lblPageInfo = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            lblCount = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            rbDelete = new RadioButton();
            rbUpdate = new RadioButton();
            rbAdd = new RadioButton();
            btnAcion = new Button();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            txtAge = new TextBox();
            txtMedal = new TextBox();
            txtAchiev = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(490, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(264, 344);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbDesc);
            panel1.Controls.Add(rbAsc);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(490, 464);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 66);
            panel1.TabIndex = 1;
            // 
            // rbDesc
            // 
            rbDesc.AutoSize = true;
            rbDesc.Location = new Point(153, 25);
            rbDesc.Name = "rbDesc";
            rbDesc.Size = new Size(62, 24);
            rbDesc.TabIndex = 2;
            rbDesc.TabStop = true;
            rbDesc.Text = "Desc";
            rbDesc.UseVisualStyleBackColor = true;
            rbDesc.CheckedChanged += rbDesc_CheckedChanged;
            // 
            // rbAsc
            // 
            rbAsc.AutoSize = true;
            rbAsc.Location = new Point(79, 23);
            rbAsc.Name = "rbAsc";
            rbAsc.Size = new Size(53, 24);
            rbAsc.TabIndex = 1;
            rbAsc.TabStop = true;
            rbAsc.Text = "Asc";
            rbAsc.UseVisualStyleBackColor = true;
            rbAsc.CheckedChanged += rbAsc_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "Sort";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(457, 547);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 52);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(538, 547);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(64, 52);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Location = new Point(617, 563);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(50, 20);
            lblPageInfo.TabIndex = 4;
            lblPageInfo.Text = "label2";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(685, 560);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblCount);
            groupBox1.Location = new Point(44, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 186);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statistics";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 78);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 1;
            label4.Text = "Categories count";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(181, 78);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(50, 20);
            lblCount.TabIndex = 0;
            lblCount.Text = "label3";
            // 
            // txtId
            // 
            txtId.Location = new Point(137, 320);
            txtId.Name = "txtId";
            txtId.Size = new Size(224, 27);
            txtId.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(137, 362);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 27);
            txtName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 323);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 9;
            label5.Text = "Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 365);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 10;
            label6.Text = "Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbDelete);
            panel2.Controls.Add(rbUpdate);
            panel2.Controls.Add(rbAdd);
            panel2.Location = new Point(37, 577);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 44);
            panel2.TabIndex = 11;
            // 
            // rbDelete
            // 
            rbDelete.AutoSize = true;
            rbDelete.Location = new Point(191, 8);
            rbDelete.Name = "rbDelete";
            rbDelete.Size = new Size(74, 24);
            rbDelete.TabIndex = 2;
            rbDelete.TabStop = true;
            rbDelete.Text = "Delete";
            rbDelete.UseVisualStyleBackColor = true;
            rbDelete.CheckedChanged += rbDelete_CheckedChanged;
            // 
            // rbUpdate
            // 
            rbUpdate.AutoSize = true;
            rbUpdate.Location = new Point(87, 8);
            rbUpdate.Name = "rbUpdate";
            rbUpdate.Size = new Size(79, 24);
            rbUpdate.TabIndex = 1;
            rbUpdate.TabStop = true;
            rbUpdate.Text = "Update";
            rbUpdate.UseVisualStyleBackColor = true;
            rbUpdate.CheckedChanged += rbUpdate_CheckedChanged;
            // 
            // rbAdd
            // 
            rbAdd.AutoSize = true;
            rbAdd.Location = new Point(23, 8);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(58, 24);
            rbAdd.TabIndex = 0;
            rbAdd.TabStop = true;
            rbAdd.Text = "Add";
            rbAdd.UseVisualStyleBackColor = true;
            rbAdd.CheckedChanged += rbAdd_CheckedChanged;
            // 
            // btnAcion
            // 
            btnAcion.Location = new Point(105, 660);
            btnAcion.Name = "btnAcion";
            btnAcion.Size = new Size(179, 68);
            btnAcion.TabIndex = 12;
            btnAcion.Text = "button1";
            btnAcion.UseVisualStyleBackColor = true;
            btnAcion.Click += btnAcion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 407);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 13;
            label2.Text = "Age group";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 449);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 14;
            label3.Text = "Medal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 491);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 15;
            label7.Text = "Achievements";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(137, 404);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(224, 27);
            txtAge.TabIndex = 16;
            // 
            // txtMedal
            // 
            txtMedal.Location = new Point(137, 446);
            txtMedal.Name = "txtMedal";
            txtMedal.Size = new Size(224, 27);
            txtMedal.TabIndex = 17;
            // 
            // txtAchiev
            // 
            txtAchiev.Location = new Point(137, 488);
            txtAchiev.Name = "txtAchiev";
            txtAchiev.Size = new Size(224, 27);
            txtAchiev.TabIndex = 18;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 740);
            Controls.Add(txtAchiev);
            Controls.Add(txtMedal);
            Controls.Add(txtAge);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAcion);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(lblPageInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Panel panel1;
        private RadioButton rbDesc;
        private RadioButton rbAsc;
        private Label label1;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblPageInfo;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label4;
        private Label lblCount;
        private TextBox txtId;
        private TextBox txtName;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private RadioButton rbDelete;
        private RadioButton rbUpdate;
        private RadioButton rbAdd;
        private Button btnAcion;
        private Label label2;
        private Label label3;
        private Label label7;
        private TextBox txtAge;
        private TextBox txtMedal;
        private TextBox txtAchiev;
    }
}