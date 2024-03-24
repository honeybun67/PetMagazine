namespace PetMagazine.FormApp
{
    partial class PetCategoriesForm
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
            lblName = new Label();
            lblBreed = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Location = new Point(27, 97);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(50, 20);
            lblBreed.TabIndex = 1;
            lblBreed.Text = "label2";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(24, 169);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(153, 85);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(20, 298);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.Yes;
            btnExit.Size = new Size(150, 78);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(305, 38);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(403, 356);
            checkedListBox1.TabIndex = 4;

            // 
            // PetCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(lblBreed);
            Controls.Add(lblName);
            Name = "PetCategoriesForm";
            Text = "PetCategoriesForm";
            Load += PetCategoriesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblBreed;
        private Button btnUpdate;
        private Button btnExit;
        private CheckedListBox checkedListBox1;
    }
}