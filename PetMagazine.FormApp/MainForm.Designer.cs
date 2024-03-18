namespace PetMagazine.FormApp
{
    partial class MainForm
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
            btnPet = new Button();
            btnCategory = new Button();
            SuspendLayout();
            // 
            // btnPet
            // 
            btnPet.Location = new Point(97, 137);
            btnPet.Name = "btnPet";
            btnPet.Size = new Size(205, 117);
            btnPet.TabIndex = 0;
            btnPet.Text = "Pet";
            btnPet.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(383, 143);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(206, 111);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCategory);
            Controls.Add(btnPet);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPet;
        private Button btnCategory;
    }
}