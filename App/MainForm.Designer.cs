namespace App
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.labAuthor = new System.Windows.Forms.Label();
            this.labSerie = new System.Windows.Forms.Label();
            this.labCategorie = new System.Windows.Forms.Label();
            this.labGenre = new System.Windows.Forms.Label();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.tabListes = new System.Windows.Forms.TabControl();
            this.tabPossede = new System.Windows.Forms.TabPage();
            this.libPossede = new System.Windows.Forms.ListBox();
            this.tabSouhait = new System.Windows.Forms.TabPage();
            this.libSouhait = new System.Windows.Forms.ListBox();
            this.tabCatalogue = new System.Windows.Forms.TabPage();
            this.libCatalogue = new System.Windows.Forms.ListBox();
            this.btnAjoutCollection = new System.Windows.Forms.Button();
            this.btnAjoutSouhait = new System.Windows.Forms.Button();
            this.grbAdministrateur = new System.Windows.Forms.GroupBox();
            this.btnEnleverAlbum = new System.Windows.Forms.Button();
            this.btnAjoutAlbum = new System.Windows.Forms.Button();
            this.btnDisconnection = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnRetraitSouhait = new System.Windows.Forms.Button();
            this.btnRetraitCollection = new System.Windows.Forms.Button();
            this.labEditeur = new System.Windows.Forms.Label();
            this.txtEditeur = new System.Windows.Forms.TextBox();
            this.grbClasser = new System.Windows.Forms.GroupBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.radEditeur = new System.Windows.Forms.RadioButton();
            this.radCategorie = new System.Windows.Forms.RadioButton();
            this.radGenre = new System.Windows.Forms.RadioButton();
            this.radSerie = new System.Windows.Forms.RadioButton();
            this.radAuteur = new System.Windows.Forms.RadioButton();
            this.radNom = new System.Windows.Forms.RadioButton();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.labRecherche = new System.Windows.Forms.Label();
            this.cmbCritere = new System.Windows.Forms.ComboBox();
            this.labCritere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.tabListes.SuspendLayout();
            this.tabPossede.SuspendLayout();
            this.tabSouhait.SuspendLayout();
            this.tabCatalogue.SuspendLayout();
            this.grbAdministrateur.SuspendLayout();
            this.grbClasser.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(492, 135);
            this.labName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 13);
            this.labName.TabIndex = 1;
            this.labName.Text = "Nom :";
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.Location = new System.Drawing.Point(492, 170);
            this.labAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(55, 13);
            this.labAuthor.TabIndex = 2;
            this.labAuthor.Text = "Auteur(s) :";
            // 
            // labSerie
            // 
            this.labSerie.AutoSize = true;
            this.labSerie.Location = new System.Drawing.Point(492, 205);
            this.labSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSerie.Name = "labSerie";
            this.labSerie.Size = new System.Drawing.Size(37, 13);
            this.labSerie.TabIndex = 3;
            this.labSerie.Text = "Série :";
            // 
            // labCategorie
            // 
            this.labCategorie.AutoSize = true;
            this.labCategorie.Location = new System.Drawing.Point(492, 240);
            this.labCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCategorie.Name = "labCategorie";
            this.labCategorie.Size = new System.Drawing.Size(58, 13);
            this.labCategorie.TabIndex = 4;
            this.labCategorie.Text = "Catégorie :";
            // 
            // labGenre
            // 
            this.labGenre.AutoSize = true;
            this.labGenre.Location = new System.Drawing.Point(492, 275);
            this.labGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGenre.Name = "labGenre";
            this.labGenre.Size = new System.Drawing.Size(42, 13);
            this.labGenre.TabIndex = 5;
            this.labGenre.Text = "Genre :";
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(528, 338);
            this.picCover.Margin = new System.Windows.Forms.Padding(2);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(180, 229);
            this.picCover.TabIndex = 6;
            this.picCover.TabStop = false;
            // 
            // tabListes
            // 
            this.tabListes.Controls.Add(this.tabPossede);
            this.tabListes.Controls.Add(this.tabSouhait);
            this.tabListes.Controls.Add(this.tabCatalogue);
            this.tabListes.Location = new System.Drawing.Point(0, 0);
            this.tabListes.Margin = new System.Windows.Forms.Padding(2);
            this.tabListes.Name = "tabListes";
            this.tabListes.SelectedIndex = 0;
            this.tabListes.Size = new System.Drawing.Size(265, 600);
            this.tabListes.TabIndex = 7;
            this.tabListes.SelectedIndexChanged += new System.EventHandler(this.tabListes_SelectedIndexChanged);
            // 
            // tabPossede
            // 
            this.tabPossede.Controls.Add(this.libPossede);
            this.tabPossede.Location = new System.Drawing.Point(4, 22);
            this.tabPossede.Margin = new System.Windows.Forms.Padding(2);
            this.tabPossede.Name = "tabPossede";
            this.tabPossede.Padding = new System.Windows.Forms.Padding(2);
            this.tabPossede.Size = new System.Drawing.Size(257, 574);
            this.tabPossede.TabIndex = 0;
            this.tabPossede.Text = "Ma collection";
            this.tabPossede.UseVisualStyleBackColor = true;
            // 
            // libPossede
            // 
            this.libPossede.FormattingEnabled = true;
            this.libPossede.Location = new System.Drawing.Point(0, 0);
            this.libPossede.Margin = new System.Windows.Forms.Padding(2);
            this.libPossede.Name = "libPossede";
            this.libPossede.Size = new System.Drawing.Size(257, 576);
            this.libPossede.TabIndex = 0;
            this.libPossede.SelectedIndexChanged += new System.EventHandler(this.lib_SelectedIndexChanged);
            // 
            // tabSouhait
            // 
            this.tabSouhait.Controls.Add(this.libSouhait);
            this.tabSouhait.Location = new System.Drawing.Point(4, 22);
            this.tabSouhait.Margin = new System.Windows.Forms.Padding(2);
            this.tabSouhait.Name = "tabSouhait";
            this.tabSouhait.Padding = new System.Windows.Forms.Padding(2);
            this.tabSouhait.Size = new System.Drawing.Size(257, 574);
            this.tabSouhait.TabIndex = 1;
            this.tabSouhait.Text = "Ma liste de souhait";
            this.tabSouhait.UseVisualStyleBackColor = true;
            // 
            // libSouhait
            // 
            this.libSouhait.FormattingEnabled = true;
            this.libSouhait.Location = new System.Drawing.Point(0, 0);
            this.libSouhait.Margin = new System.Windows.Forms.Padding(2);
            this.libSouhait.Name = "libSouhait";
            this.libSouhait.Size = new System.Drawing.Size(257, 576);
            this.libSouhait.TabIndex = 0;
            this.libSouhait.SelectedIndexChanged += new System.EventHandler(this.lib_SelectedIndexChanged);
            // 
            // tabCatalogue
            // 
            this.tabCatalogue.Controls.Add(this.libCatalogue);
            this.tabCatalogue.Location = new System.Drawing.Point(4, 22);
            this.tabCatalogue.Margin = new System.Windows.Forms.Padding(2);
            this.tabCatalogue.Name = "tabCatalogue";
            this.tabCatalogue.Padding = new System.Windows.Forms.Padding(2);
            this.tabCatalogue.Size = new System.Drawing.Size(257, 574);
            this.tabCatalogue.TabIndex = 2;
            this.tabCatalogue.Text = "Catalogue";
            this.tabCatalogue.UseVisualStyleBackColor = true;
            // 
            // libCatalogue
            // 
            this.libCatalogue.FormattingEnabled = true;
            this.libCatalogue.Location = new System.Drawing.Point(0, 0);
            this.libCatalogue.Margin = new System.Windows.Forms.Padding(2);
            this.libCatalogue.Name = "libCatalogue";
            this.libCatalogue.Size = new System.Drawing.Size(255, 576);
            this.libCatalogue.TabIndex = 12;
            this.libCatalogue.SelectedIndexChanged += new System.EventHandler(this.lib_SelectedIndexChanged);
            // 
            // btnAjoutCollection
            // 
            this.btnAjoutCollection.Location = new System.Drawing.Point(436, 581);
            this.btnAjoutCollection.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutCollection.Name = "btnAjoutCollection";
            this.btnAjoutCollection.Size = new System.Drawing.Size(158, 37);
            this.btnAjoutCollection.TabIndex = 8;
            this.btnAjoutCollection.Text = "Ajouter à ma collection";
            this.btnAjoutCollection.UseVisualStyleBackColor = true;
            this.btnAjoutCollection.Click += new System.EventHandler(this.btnAjoutCollection_Click);
            // 
            // btnAjoutSouhait
            // 
            this.btnAjoutSouhait.Location = new System.Drawing.Point(624, 581);
            this.btnAjoutSouhait.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutSouhait.Name = "btnAjoutSouhait";
            this.btnAjoutSouhait.Size = new System.Drawing.Size(158, 37);
            this.btnAjoutSouhait.TabIndex = 9;
            this.btnAjoutSouhait.Text = "Ajouter à ma liste de souhait";
            this.btnAjoutSouhait.UseVisualStyleBackColor = true;
            this.btnAjoutSouhait.Click += new System.EventHandler(this.btnAjoutSouhait_Click);
            // 
            // grbAdministrateur
            // 
            this.grbAdministrateur.Controls.Add(this.btnEnleverAlbum);
            this.grbAdministrateur.Controls.Add(this.btnAjoutAlbum);
            this.grbAdministrateur.Location = new System.Drawing.Point(824, 165);
            this.grbAdministrateur.Margin = new System.Windows.Forms.Padding(2);
            this.grbAdministrateur.Name = "grbAdministrateur";
            this.grbAdministrateur.Padding = new System.Windows.Forms.Padding(2);
            this.grbAdministrateur.Size = new System.Drawing.Size(124, 381);
            this.grbAdministrateur.TabIndex = 10;
            this.grbAdministrateur.TabStop = false;
            this.grbAdministrateur.Text = "Actions administrateur";
            // 
            // btnEnleverAlbum
            // 
            this.btnEnleverAlbum.Location = new System.Drawing.Point(15, 164);
            this.btnEnleverAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnleverAlbum.Name = "btnEnleverAlbum";
            this.btnEnleverAlbum.Size = new System.Drawing.Size(98, 63);
            this.btnEnleverAlbum.TabIndex = 1;
            this.btnEnleverAlbum.Text = "Enlever l\'album sélectionné du catalogue";
            this.btnEnleverAlbum.UseVisualStyleBackColor = true;
            this.btnEnleverAlbum.Click += new System.EventHandler(this.btnEnleverAlbum_Click);
            // 
            // btnAjoutAlbum
            // 
            this.btnAjoutAlbum.Location = new System.Drawing.Point(15, 56);
            this.btnAjoutAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutAlbum.Name = "btnAjoutAlbum";
            this.btnAjoutAlbum.Size = new System.Drawing.Size(98, 66);
            this.btnAjoutAlbum.TabIndex = 0;
            this.btnAjoutAlbum.Text = "Ajouter un album au catalogue";
            this.btnAjoutAlbum.UseVisualStyleBackColor = true;
            this.btnAjoutAlbum.Click += new System.EventHandler(this.btnAjoutAlbum_Click);
            // 
            // btnDisconnection
            // 
            this.btnDisconnection.Location = new System.Drawing.Point(830, 20);
            this.btnDisconnection.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnection.Name = "btnDisconnection";
            this.btnDisconnection.Size = new System.Drawing.Size(106, 29);
            this.btnDisconnection.TabIndex = 11;
            this.btnDisconnection.Text = "Se déconnecter";
            this.btnDisconnection.UseVisualStyleBackColor = true;
            this.btnDisconnection.Click += new System.EventHandler(this.btnDisconnection_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(572, 132);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(106, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(572, 170);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(106, 20);
            this.txtAuthor.TabIndex = 13;
            // 
            // txtSerie
            // 
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(572, 202);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(106, 20);
            this.txtSerie.TabIndex = 14;
            // 
            // txtCategorie
            // 
            this.txtCategorie.Enabled = false;
            this.txtCategorie.Location = new System.Drawing.Point(572, 238);
            this.txtCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(106, 20);
            this.txtCategorie.TabIndex = 15;
            // 
            // txtGenre
            // 
            this.txtGenre.Enabled = false;
            this.txtGenre.Location = new System.Drawing.Point(572, 272);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(106, 20);
            this.txtGenre.TabIndex = 16;
            // 
            // btnRetraitSouhait
            // 
            this.btnRetraitSouhait.Location = new System.Drawing.Point(624, 581);
            this.btnRetraitSouhait.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetraitSouhait.Name = "btnRetraitSouhait";
            this.btnRetraitSouhait.Size = new System.Drawing.Size(158, 37);
            this.btnRetraitSouhait.TabIndex = 17;
            this.btnRetraitSouhait.Text = "Retirer de ma liste de souhait";
            this.btnRetraitSouhait.UseVisualStyleBackColor = true;
            this.btnRetraitSouhait.Click += new System.EventHandler(this.btnRetraitSouhait_Click);
            // 
            // btnRetraitCollection
            // 
            this.btnRetraitCollection.Location = new System.Drawing.Point(624, 581);
            this.btnRetraitCollection.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetraitCollection.Name = "btnRetraitCollection";
            this.btnRetraitCollection.Size = new System.Drawing.Size(158, 37);
            this.btnRetraitCollection.TabIndex = 18;
            this.btnRetraitCollection.Text = "Retirer de ma collection";
            this.btnRetraitCollection.UseVisualStyleBackColor = true;
            this.btnRetraitCollection.Click += new System.EventHandler(this.btnRetraitCollection_Click);
            // 
            // labEditeur
            // 
            this.labEditeur.AutoSize = true;
            this.labEditeur.Location = new System.Drawing.Point(492, 303);
            this.labEditeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labEditeur.Name = "labEditeur";
            this.labEditeur.Size = new System.Drawing.Size(46, 13);
            this.labEditeur.TabIndex = 19;
            this.labEditeur.Text = "Editeur :";
            // 
            // txtEditeur
            // 
            this.txtEditeur.Enabled = false;
            this.txtEditeur.Location = new System.Drawing.Point(572, 303);
            this.txtEditeur.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditeur.Name = "txtEditeur";
            this.txtEditeur.Size = new System.Drawing.Size(106, 20);
            this.txtEditeur.TabIndex = 20;
            // 
            // grbClasser
            // 
            this.grbClasser.Controls.Add(this.btnRetour);
            this.grbClasser.Controls.Add(this.radEditeur);
            this.grbClasser.Controls.Add(this.radCategorie);
            this.grbClasser.Controls.Add(this.radGenre);
            this.grbClasser.Controls.Add(this.radSerie);
            this.grbClasser.Controls.Add(this.radAuteur);
            this.grbClasser.Controls.Add(this.radNom);
            this.grbClasser.Location = new System.Drawing.Point(295, 117);
            this.grbClasser.Name = "grbClasser";
            this.grbClasser.Size = new System.Drawing.Size(93, 242);
            this.grbClasser.TabIndex = 21;
            this.grbClasser.TabStop = false;
            this.grbClasser.Text = "Classer par :";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(7, 212);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // radEditeur
            // 
            this.radEditeur.AutoSize = true;
            this.radEditeur.Location = new System.Drawing.Point(7, 178);
            this.radEditeur.Name = "radEditeur";
            this.radEditeur.Size = new System.Drawing.Size(63, 17);
            this.radEditeur.TabIndex = 5;
            this.radEditeur.TabStop = true;
            this.radEditeur.Text = "Editeurs";
            this.radEditeur.UseVisualStyleBackColor = true;
            this.radEditeur.CheckedChanged += new System.EventHandler(this.radEditeur_CheckedChanged);
            // 
            // radCategorie
            // 
            this.radCategorie.AutoSize = true;
            this.radCategorie.Location = new System.Drawing.Point(7, 150);
            this.radCategorie.Name = "radCategorie";
            this.radCategorie.Size = new System.Drawing.Size(75, 17);
            this.radCategorie.TabIndex = 4;
            this.radCategorie.TabStop = true;
            this.radCategorie.Text = "Catégories";
            this.radCategorie.UseVisualStyleBackColor = true;
            this.radCategorie.CheckedChanged += new System.EventHandler(this.radCategorie_CheckedChanged);
            // 
            // radGenre
            // 
            this.radGenre.AutoSize = true;
            this.radGenre.Location = new System.Drawing.Point(7, 122);
            this.radGenre.Name = "radGenre";
            this.radGenre.Size = new System.Drawing.Size(59, 17);
            this.radGenre.TabIndex = 3;
            this.radGenre.TabStop = true;
            this.radGenre.Text = "Genres";
            this.radGenre.UseVisualStyleBackColor = true;
            this.radGenre.CheckedChanged += new System.EventHandler(this.radGenre_CheckedChanged);
            // 
            // radSerie
            // 
            this.radSerie.AutoSize = true;
            this.radSerie.Location = new System.Drawing.Point(7, 94);
            this.radSerie.Name = "radSerie";
            this.radSerie.Size = new System.Drawing.Size(54, 17);
            this.radSerie.TabIndex = 2;
            this.radSerie.TabStop = true;
            this.radSerie.Text = "Séries";
            this.radSerie.UseVisualStyleBackColor = true;
            this.radSerie.CheckedChanged += new System.EventHandler(this.radSerie_CheckedChanged);
            // 
            // radAuteur
            // 
            this.radAuteur.AutoSize = true;
            this.radAuteur.Location = new System.Drawing.Point(7, 66);
            this.radAuteur.Name = "radAuteur";
            this.radAuteur.Size = new System.Drawing.Size(61, 17);
            this.radAuteur.TabIndex = 1;
            this.radAuteur.TabStop = true;
            this.radAuteur.Text = "Auteurs";
            this.radAuteur.UseVisualStyleBackColor = true;
            this.radAuteur.CheckedChanged += new System.EventHandler(this.radAuteur_CheckedChanged);
            // 
            // radNom
            // 
            this.radNom.AutoSize = true;
            this.radNom.Location = new System.Drawing.Point(7, 38);
            this.radNom.Name = "radNom";
            this.radNom.Size = new System.Drawing.Size(52, 17);
            this.radNom.TabIndex = 0;
            this.radNom.TabStop = true;
            this.radNom.Text = "Noms";
            this.radNom.UseVisualStyleBackColor = true;
            this.radNom.CheckedChanged += new System.EventHandler(this.radNom_CheckedChanged);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(416, 25);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(217, 20);
            this.txtRecherche.TabIndex = 22;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(644, 22);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(70, 24);
            this.btnRecherche.TabIndex = 23;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // labRecherche
            // 
            this.labRecherche.AutoSize = true;
            this.labRecherche.Location = new System.Drawing.Point(292, 27);
            this.labRecherche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labRecherche.Name = "labRecherche";
            this.labRecherche.Size = new System.Drawing.Size(121, 13);
            this.labRecherche.TabIndex = 24;
            this.labRecherche.Text = "Rechercher un mot-clé :";
            // 
            // cmbCritere
            // 
            this.cmbCritere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCritere.FormattingEnabled = true;
            this.cmbCritere.Location = new System.Drawing.Point(416, 50);
            this.cmbCritere.Name = "cmbCritere";
            this.cmbCritere.Size = new System.Drawing.Size(121, 21);
            this.cmbCritere.TabIndex = 25;
            // 
            // labCritere
            // 
            this.labCritere.AutoSize = true;
            this.labCritere.Location = new System.Drawing.Point(373, 53);
            this.labCritere.Name = "labCritere";
            this.labCritere.Size = new System.Drawing.Size(40, 13);
            this.labCritere.TabIndex = 26;
            this.labCritere.Text = "Selon :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.labCritere);
            this.Controls.Add(this.cmbCritere);
            this.Controls.Add(this.labRecherche);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.grbClasser);
            this.Controls.Add(this.txtEditeur);
            this.Controls.Add(this.labEditeur);
            this.Controls.Add(this.btnRetraitCollection);
            this.Controls.Add(this.btnRetraitSouhait);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDisconnection);
            this.Controls.Add(this.grbAdministrateur);
            this.Controls.Add(this.btnAjoutSouhait);
            this.Controls.Add(this.btnAjoutCollection);
            this.Controls.Add(this.tabListes);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.labGenre);
            this.Controls.Add(this.labCategorie);
            this.Controls.Add(this.labSerie);
            this.Controls.Add(this.labAuthor);
            this.Controls.Add(this.labName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "BDThèque";
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.tabListes.ResumeLayout(false);
            this.tabPossede.ResumeLayout(false);
            this.tabSouhait.ResumeLayout(false);
            this.tabCatalogue.ResumeLayout(false);
            this.grbAdministrateur.ResumeLayout(false);
            this.grbClasser.ResumeLayout(false);
            this.grbClasser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.Label labSerie;
        private System.Windows.Forms.Label labCategorie;
        private System.Windows.Forms.Label labGenre;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.TabControl tabListes;
        private System.Windows.Forms.TabPage tabPossede;
        private System.Windows.Forms.TabPage tabSouhait;
        private System.Windows.Forms.TabPage tabCatalogue;
        private System.Windows.Forms.Button btnAjoutCollection;
        private System.Windows.Forms.Button btnAjoutSouhait;
        private System.Windows.Forms.GroupBox grbAdministrateur;
        private System.Windows.Forms.Button btnEnleverAlbum;
        private System.Windows.Forms.Button btnAjoutAlbum;
        private System.Windows.Forms.Button btnDisconnection;
        private System.Windows.Forms.ListBox libPossede;
        private System.Windows.Forms.ListBox libSouhait;
        private System.Windows.Forms.ListBox libCatalogue;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnRetraitSouhait;
        private System.Windows.Forms.Button btnRetraitCollection;
        private System.Windows.Forms.Label labEditeur;
        private System.Windows.Forms.TextBox txtEditeur;
        private System.Windows.Forms.GroupBox grbClasser;
        private System.Windows.Forms.RadioButton radEditeur;
        private System.Windows.Forms.RadioButton radCategorie;
        private System.Windows.Forms.RadioButton radGenre;
        private System.Windows.Forms.RadioButton radSerie;
        private System.Windows.Forms.RadioButton radAuteur;
        private System.Windows.Forms.RadioButton radNom;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label labRecherche;
        private System.Windows.Forms.ComboBox cmbCritere;
        private System.Windows.Forms.Label labCritere;
    }
}

