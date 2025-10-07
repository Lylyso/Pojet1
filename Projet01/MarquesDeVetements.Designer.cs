namespace Projet01
{
    partial class MarqueVetementsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarqueVetementsForm));
            this.policeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.policeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.vetementPictureBox = new System.Windows.Forms.PictureBox();
            this.marqueLabel = new System.Windows.Forms.Label();
            this.vetementRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imprimerButton = new System.Windows.Forms.Button();
            this.rechercheGroupBox = new System.Windows.Forms.GroupBox();
            this.compteurMarqueButton = new System.Windows.Forms.Button();
            this.marqueRechercherlabel = new System.Windows.Forms.Label();
            this.rechercheTextBox = new System.Windows.Forms.TextBox();
            this.policeMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vetementPictureBox)).BeginInit();
            this.rechercheGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // policeMenuStrip
            // 
            this.policeMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.policeMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.policeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.policeToolStripComboBox});
            this.policeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.policeMenuStrip.Name = "policeMenuStrip";
            this.policeMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.policeMenuStrip.Size = new System.Drawing.Size(796, 37);
            this.policeMenuStrip.TabIndex = 0;
            this.policeMenuStrip.Text = "menuStrip1";
            // 
            // policeToolStripComboBox
            // 
            this.policeToolStripComboBox.Name = "policeToolStripComboBox";
            this.policeToolStripComboBox.Size = new System.Drawing.Size(136, 33);
            this.policeToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.PoliceToolStripComboBox_SelectedIndexChanged);
            // 
            // vetementPictureBox
            // 
            this.vetementPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vetementPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("vetementPictureBox.Image")));
            this.vetementPictureBox.Location = new System.Drawing.Point(129, 74);
            this.vetementPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vetementPictureBox.Name = "vetementPictureBox";
            this.vetementPictureBox.Size = new System.Drawing.Size(529, 276);
            this.vetementPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vetementPictureBox.TabIndex = 1;
            this.vetementPictureBox.TabStop = false;
            // 
            // marqueLabel
            // 
            this.marqueLabel.AutoSize = true;
            this.marqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marqueLabel.Location = new System.Drawing.Point(14, 372);
            this.marqueLabel.Name = "marqueLabel";
            this.marqueLabel.Size = new System.Drawing.Size(604, 20);
            this.marqueLabel.TabIndex = 2;
            this.marqueLabel.Text = "Marque de vetement :  (selection indique plusieurs marques de vêtements)";
            // 
            // vetementRichTextBox
            // 
            this.vetementRichTextBox.Location = new System.Drawing.Point(17, 412);
            this.vetementRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vetementRichTextBox.Name = "vetementRichTextBox";
            this.vetementRichTextBox.Size = new System.Drawing.Size(751, 234);
            this.vetementRichTextBox.TabIndex = 3;
            this.vetementRichTextBox.Text = "";
            // 
            // imprimerButton
            // 
            this.imprimerButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imprimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimerButton.Location = new System.Drawing.Point(17, 655);
            this.imprimerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imprimerButton.Name = "imprimerButton";
            this.imprimerButton.Size = new System.Drawing.Size(752, 72);
            this.imprimerButton.TabIndex = 4;
            this.imprimerButton.Text = "Imprimer la liste des marques";
            this.imprimerButton.UseVisualStyleBackColor = false;
            // 
            // rechercheGroupBox
            // 
            this.rechercheGroupBox.Controls.Add(this.compteurMarqueButton);
            this.rechercheGroupBox.Controls.Add(this.marqueRechercherlabel);
            this.rechercheGroupBox.Controls.Add(this.rechercheTextBox);
            this.rechercheGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercheGroupBox.Location = new System.Drawing.Point(17, 760);
            this.rechercheGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rechercheGroupBox.Name = "rechercheGroupBox";
            this.rechercheGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rechercheGroupBox.Size = new System.Drawing.Size(752, 220);
            this.rechercheGroupBox.TabIndex = 5;
            this.rechercheGroupBox.TabStop = false;
            this.rechercheGroupBox.Text = "Recherche";
            // 
            // compteurMarqueButton
            // 
            this.compteurMarqueButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.compteurMarqueButton.Location = new System.Drawing.Point(10, 101);
            this.compteurMarqueButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compteurMarqueButton.Name = "compteurMarqueButton";
            this.compteurMarqueButton.Size = new System.Drawing.Size(735, 66);
            this.compteurMarqueButton.TabIndex = 2;
            this.compteurMarqueButton.Text = "Afficher le nombre des marques";
            this.compteurMarqueButton.UseVisualStyleBackColor = false;
            this.compteurMarqueButton.Click += new System.EventHandler(this.CompteurMarqueButton_Click);
            // 
            // marqueRechercherlabel
            // 
            this.marqueRechercherlabel.AutoSize = true;
            this.marqueRechercherlabel.Location = new System.Drawing.Point(7, 42);
            this.marqueRechercherlabel.Name = "marqueRechercherlabel";
            this.marqueRechercherlabel.Size = new System.Drawing.Size(596, 20);
            this.marqueRechercherlabel.TabIndex = 1;
            this.marqueRechercherlabel.Text = "La marque recherchée (Zara, Levi\'s, Dior, Nike, Guess, Mango, Simons ) :";
            // 
            // rechercheTextBox
            // 
            this.rechercheTextBox.Location = new System.Drawing.Point(10, 66);
            this.rechercheTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rechercheTextBox.Name = "rechercheTextBox";
            this.rechercheTextBox.Size = new System.Drawing.Size(734, 25);
            this.rechercheTextBox.TabIndex = 0;
            // 
            // MarqueVetementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(796, 996);
            this.Controls.Add(this.rechercheGroupBox);
            this.Controls.Add(this.imprimerButton);
            this.Controls.Add(this.vetementRichTextBox);
            this.Controls.Add(this.marqueLabel);
            this.Controls.Add(this.vetementPictureBox);
            this.Controls.Add(this.policeMenuStrip);
            this.MainMenuStrip = this.policeMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MarqueVetementsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marques de vetements";
            this.Load += new System.EventHandler(this.MarqueVetementsForm_Load);
            this.policeMenuStrip.ResumeLayout(false);
            this.policeMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vetementPictureBox)).EndInit();
            this.rechercheGroupBox.ResumeLayout(false);
            this.rechercheGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip policeMenuStrip;
        private System.Windows.Forms.ToolStripComboBox policeToolStripComboBox;
        private System.Windows.Forms.PictureBox vetementPictureBox;
        private System.Windows.Forms.Label marqueLabel;
        private System.Windows.Forms.RichTextBox vetementRichTextBox;
        private System.Windows.Forms.Button imprimerButton;
        private System.Windows.Forms.GroupBox rechercheGroupBox;
        private System.Windows.Forms.TextBox rechercheTextBox;
        private System.Windows.Forms.Button compteurMarqueButton;
        private System.Windows.Forms.Label marqueRechercherlabel;
    }
}

