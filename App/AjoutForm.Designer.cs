namespace App
{
    partial class AjoutForm
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
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labGenre = new System.Windows.Forms.Label();
            this.labCategorie = new System.Windows.Forms.Label();
            this.labSerie = new System.Windows.Forms.Label();
            this.labAuthor = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnAjoutImage = new System.Windows.Forms.Button();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.labCover = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEditeur = new System.Windows.Forms.TextBox();
            this.labEditeur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(377, 318);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(207, 31);
            this.txtGenre.TabIndex = 26;
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(377, 253);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(207, 31);
            this.txtCategorie.TabIndex = 25;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(377, 181);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(207, 31);
            this.txtSerie.TabIndex = 24;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(377, 120);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(207, 31);
            this.txtAuthor.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(377, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 31);
            this.txtName.TabIndex = 22;
            // 
            // labGenre
            // 
            this.labGenre.AutoSize = true;
            this.labGenre.Location = new System.Drawing.Point(133, 321);
            this.labGenre.Name = "labGenre";
            this.labGenre.Size = new System.Drawing.Size(83, 25);
            this.labGenre.TabIndex = 21;
            this.labGenre.Text = "Genre :";
            // 
            // labCategorie
            // 
            this.labCategorie.AutoSize = true;
            this.labCategorie.Location = new System.Drawing.Point(133, 254);
            this.labCategorie.Name = "labCategorie";
            this.labCategorie.Size = new System.Drawing.Size(117, 25);
            this.labCategorie.TabIndex = 20;
            this.labCategorie.Text = "Catégorie :";
            // 
            // labSerie
            // 
            this.labSerie.AutoSize = true;
            this.labSerie.Location = new System.Drawing.Point(133, 187);
            this.labSerie.Name = "labSerie";
            this.labSerie.Size = new System.Drawing.Size(74, 25);
            this.labSerie.TabIndex = 19;
            this.labSerie.Text = "Série :";
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.Location = new System.Drawing.Point(133, 120);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(112, 25);
            this.labAuthor.TabIndex = 18;
            this.labAuthor.Text = "Auteur(s) :";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(133, 53);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(68, 25);
            this.labName.TabIndex = 17;
            this.labName.Text = "Nom :";
            // 
            // btnAjoutImage
            // 
            this.btnAjoutImage.Location = new System.Drawing.Point(377, 419);
            this.btnAjoutImage.Name = "btnAjoutImage";
            this.btnAjoutImage.Size = new System.Drawing.Size(207, 41);
            this.btnAjoutImage.TabIndex = 27;
            this.btnAjoutImage.Text = "Ajouter une image";
            this.btnAjoutImage.UseVisualStyleBackColor = true;
            this.btnAjoutImage.Click += new System.EventHandler(this.btnAjoutImage_Click);
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(298, 481);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(360, 440);
            this.picCover.TabIndex = 28;
            this.picCover.TabStop = false;
            // 
            // labCover
            // 
            this.labCover.AutoSize = true;
            this.labCover.Location = new System.Drawing.Point(133, 427);
            this.labCover.Name = "labCover";
            this.labCover.Size = new System.Drawing.Size(130, 25);
            this.labCover.TabIndex = 29;
            this.labCover.Text = "Couverture :";
            // 
            // btnValider
            // 
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnValider.Location = new System.Drawing.Point(187, 939);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(185, 79);
            this.btnValider.TabIndex = 30;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(512, 939);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 79);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtEditeur
            // 
            this.txtEditeur.Location = new System.Drawing.Point(377, 370);
            this.txtEditeur.Name = "txtEditeur";
            this.txtEditeur.Size = new System.Drawing.Size(207, 31);
            this.txtEditeur.TabIndex = 33;
            // 
            // labEditeur
            // 
            this.labEditeur.AutoSize = true;
            this.labEditeur.Location = new System.Drawing.Point(133, 376);
            this.labEditeur.Name = "labEditeur";
            this.labEditeur.Size = new System.Drawing.Size(92, 25);
            this.labEditeur.TabIndex = 32;
            this.labEditeur.Text = "Editeur :";
            // 
            // AjoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 1058);
            this.Controls.Add(this.txtEditeur);
            this.Controls.Add(this.labEditeur);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.labCover);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.btnAjoutImage);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labGenre);
            this.Controls.Add(this.labCategorie);
            this.Controls.Add(this.labSerie);
            this.Controls.Add(this.labAuthor);
            this.Controls.Add(this.labName);
            this.Name = "AjoutForm";
            this.Text = "Ajouter un album";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AjoutForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labGenre;
        private System.Windows.Forms.Label labCategorie;
        private System.Windows.Forms.Label labSerie;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnAjoutImage;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label labCover;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEditeur;
        private System.Windows.Forms.Label labEditeur;
    }
}